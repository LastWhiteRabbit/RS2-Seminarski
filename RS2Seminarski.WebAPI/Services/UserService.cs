﻿using AutoMapper;
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
            var entity = base.InsertAsync(insert);

            foreach (var roleId in insert.RoleIdList)
            {
                Database.UserRole userRoles = new Database.UserRole();
                userRoles.RoleId = roleId;
                userRoles.UserId = entity.Id;
                userRoles.DateEdited = DateTime.Now;

                await _context.UserRoles.AddAsync(userRoles);
            }

            await _context.SaveChangesAsync();

            return await entity;
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
            return Convert.ToBase64String(new byte[16]);

            //var buf = new byte[16];
            //object p = (new RSACryptoServiceProvider()).GetBytes(buf);
            //return Convert.ToBase64String(buf);
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
    }

}

