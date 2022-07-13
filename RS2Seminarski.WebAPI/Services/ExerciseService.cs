using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
        public override async Task<Model.Exercise> InsertAsync(ExerciseInsertRequest insert)
        {
            var entity = await base.InsertAsync(insert);

            foreach (var muscleId in insert.MuscleIdList)
            {
                Database.ExerciseMuscle exerciseMuscle = new Database.ExerciseMuscle();
                exerciseMuscle.ExerciseId = entity.ExerciseId;
                exerciseMuscle.MuscleId = muscleId;

                await _context.ExerciseMuscles.AddAsync(exerciseMuscle);
            }

            foreach (var exerciseTypeId in insert.ExerciseTypeIdList)
            {
                Database.ExerciseExerciseType exerciseExerciseType = new Database.ExerciseExerciseType();
                exerciseExerciseType.ExerciseId = entity.ExerciseId;
                exerciseExerciseType.ExerciseTypeId = exerciseTypeId;

                await _context.ExerciseExerciseTypes.AddAsync(exerciseExerciseType);
            }

            await _context.SaveChangesAsync();

            return entity;
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

        public override IQueryable<Database.Exercise> AddInclude(IQueryable<Database.Exercise> query, ExerciseSearchObject search = null)
        {

            query = query.Include("ExerciseMuscles.Muscle").Include("ExerciseExerciseTypes.ExerciseType");
            
            return query;
        }
    }
}
