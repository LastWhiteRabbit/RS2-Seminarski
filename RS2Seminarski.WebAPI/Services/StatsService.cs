using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RS2Seminarski.Model;
using RS2Seminarski.WebAPI.Database;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Services
{
    public class StatsService : IStatsService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public StatsService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<ChartResponse>> exercisesPerLevel()
        {
            var exercises = await _context.Exercises.ToListAsync();
            var exerciseLevel = await _context.Levels.ToListAsync();

            var response = new List<ChartResponse>();

            foreach (var level in exerciseLevel)
            {
                response.Add(new ChartResponse
                {
                    Label = level.LevelName,
                    Value = exercises.Where(x => x.LevelId == level.LevelId).Count()
                });
            }


            return response.OrderByDescending(x => x.Value).ToList();
        }

        public async Task<List<ChartResponse>> exercisesPerMuscle()
        {
            var exerciseMuscles = await _context.Muscles.ToListAsync();

            var response = new List<ChartResponse>();


            foreach (var muscle in exerciseMuscles)
            {

                response.Add(new ChartResponse
                {
                    Label = muscle.MuscleName,
                    Value = _context.ExerciseMuscles
                                    .Where(p => p.MuscleId == muscle.MuscleId)
                                    .OrderByDescending(p => p.ExerciseMuscleId)
                                    .Count()
                });
            }

            return response.OrderByDescending(x => x.Value).ToList();
        }

        public async Task<List<ChartResponse>> exercisesPerType()
        {
            var exerciseTypes = await _context.ExerciseTypes.ToListAsync();

            var response = new List<ChartResponse>();


            foreach (var type in exerciseTypes)
            {

                response.Add(new ChartResponse
                {
                    Label = type.ExerciseTypeName,
                    Value = _context.ExerciseExerciseTypes
                                    .Where(p => p.ExerciseTypeId == type.ExerciseTypeId)
                                    .OrderByDescending(p => p.ExerciseExerciseTypeId)
                                    .Count()
                });
            }

            return response.OrderByDescending(x => x.Value).ToList();
        }
    }
}
