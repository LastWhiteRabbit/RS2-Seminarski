using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RS2Seminarski.Model.Requests;
using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WebAPI.Database;
using RS2Seminarski.WebAPI.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace RS2Seminarski.WebAPI.Services
{
    public class UserService :
        BaseCRUDService<Model.User, Database.User, UserSearchObject, UserInsertRequest, UserUpdateRequest>, IUserService
    {
        public UserService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<Model.User> InsertAsync(UserInsertRequest insert)
        {
            var entity = await base.InsertAsync(insert);

            foreach (var roleId in insert.RoleIdList)
            {
                Database.UserRole userRoles = new Database.UserRole();
                userRoles.RoleId = roleId;
                userRoles.UserId = entity.UserId;
                userRoles.DateEdited = DateTime.Now;

                await _context.UserRoles.AddAsync(userRoles);
            }

            await _context.SaveChangesAsync();

            return  entity;
        }

        public override void BeforeInsert(UserInsertRequest insert, User entity)
        {
            var salt = GenerateSalt();
            entity.PaswordSalt = salt;
            entity.PasswordHash = GenerateHash(salt, insert.Password);
            base.BeforeInsert(insert, entity);
        }


        public static string GenerateSalt()
        {
            //return Convert.ToBase64String(new byte[16]);

            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[16];
            provider.GetBytes(byteArray);

            return Convert.ToBase64String(byteArray);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public override IQueryable<Database.User> AddFilter(IQueryable<Database.User> query, UserSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Name))
            {
                filteredQuery = filteredQuery.Where(x => x.UserName == search.Name);
            }



            return filteredQuery;
        }

        public override IQueryable<User> AddInclude(IQueryable<User> query, UserSearchObject search = null)
        {
            if (search.IncludeRoles == true)
            {
                query = query.Include("UserRoles.Role");
            }
            return query;
        }

        public Model.User Login(string username, string password)
        {
            var entity = _context.Users.Include("UserRoles.Role").FirstOrDefault(x => x.UserName == username);

            if (entity == null)
            {
                return null;
            }

            var hash = GenerateHash(entity.PaswordSalt, password);

            if(hash != entity.PasswordHash)
            {
                return null;
            }

            return _mapper.Map<Model.User>(entity);
        }
    }

}

