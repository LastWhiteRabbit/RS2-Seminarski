using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RS2Seminarski.Model.Requests;
using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WebAPI.Database;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Services
{
    public class RoutineService :
        BaseCRUDService<Model.Routine, Database.Routine, RoutineSearchObject, RoutineInsertRequest, RoutineUpdateRequest>, IRoutineService
    {
        public RoutineService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override async Task<Model.Routine> InsertAsync(RoutineInsertRequest insert)
        {
            var entity = await base.InsertAsync(insert);


            foreach (var exerciseId in insert.ExerciseIdList)
            {
                Database.RoutineExercise routineExercise = new Database.RoutineExercise();
                routineExercise.RoutineId = entity.RoutineId;
                routineExercise.ExerciseId = exerciseId;

                await _context.RoutineExercises.AddAsync(routineExercise);
            }

    

            await _context.SaveChangesAsync();

            return entity;
        }

        public override IQueryable<Database.Routine> AddFilter(IQueryable<Database.Routine> query, RoutineSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.RoutineName))
            {
                filteredQuery = filteredQuery.Where(x => x.RoutineName == search.RoutineName);
            }


            return filteredQuery;
        }

        public override IQueryable<Database.Routine> AddInclude(IQueryable<Database.Routine> query, RoutineSearchObject search = null)
        {

            query = query.Include("RoutineExercises.Exercise");

            return query;
        }
    }
}
