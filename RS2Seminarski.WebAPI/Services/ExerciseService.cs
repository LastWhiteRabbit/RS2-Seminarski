using AutoMapper;
using RS2Seminarski.Model.Requests;
using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WebAPI.Database;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Services
{
    public class ExerciseService :
        BaseCRUDService<Model.Exercise, Database.Exercise, ExerciseSearchObject, ExerciseInsertRequest, ExerciseUpdateRequest>, IExerciseService
    {
        public ExerciseService(DataContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<Database.Exercise> AddFilter(IQueryable<Database.Exercise> query, ExerciseSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.ExerciseName))
            {
                filteredQuery = filteredQuery.Where(x => x.ExerciseName == search.ExerciseName);
            }


            return filteredQuery;
        }
    }
}
