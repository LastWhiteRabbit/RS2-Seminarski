using AutoMapper;
using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WebAPI.Database;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Services
{
    public class BaseCRUDService<T, TDb, TSearch, TInsert, TUpdate> :
        BaseService<T, TDb, TSearch>, ICRUDService<T, TSearch, TInsert, TUpdate>
            where T : class where TDb : class where TSearch : BaseSearchObject where TInsert : class where TUpdate : class

    {
        public BaseCRUDService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual async Task<T> InsertAsync(TInsert insert)
        {
            var set = _context.Set<TDb>();

            TDb entity = _mapper.Map<TDb>(insert);

            await set.AddAsync(entity);

            BeforeInsert(insert, entity);

            await _context.SaveChangesAsync();

            return _mapper.Map<T>(entity);
        }

        public virtual void BeforeInsert(TInsert insert, TDb entity)
        {

        }

        public virtual async Task<T> UpdateAsync(int id, TUpdate update)
        {
            var set = _context.Set<TDb>();

            var entity = await set.FindAsync(id);

            _mapper.Map(update, entity);

            await _context.SaveChangesAsync();

            return _mapper.Map<T>(entity);

        }
    }
}
