using AutoMapper;
using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WebAPI.Database;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Services
{
    public class LevelService : BaseService<Model.Level, Database.Level, LevelSearchObject>, ILevelService
    {
        public LevelService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override IQueryable<Database.Level> AddFilter(IQueryable<Database.Level> query, LevelSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.LevelName))
            {
                filteredQuery = filteredQuery.Where(x => x.LevelName == search.LevelName);
            }


            return filteredQuery;
        }
    }
}
