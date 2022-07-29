using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
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

        static object isLocked = new object();
        static MLContext mlContext = null;
        static ITransformer model = null;

        public List<Model.Exercise> Recommend(int id)
        {
            lock (isLocked)
            {
                if (mlContext == null)
                {
                    mlContext = new MLContext();

                    var tmpData = _context.Routines.Include("RoutineExercises").ToList();

                    var data = new List<ExerciseEntry>();

                    foreach (var x in tmpData)
                    {
                        if (x.RoutineExercises.Count > 1)
                        {
                            var distinctExerciseId = x.RoutineExercises.Select(y => y.ExerciseId).ToList();

                            distinctExerciseId.ForEach(y =>
                            {
                                var relatedExercises = x.RoutineExercises.Where(z => z.ExerciseId != y);

                                foreach (var z in relatedExercises)
                                {
                                    data.Add(new ExerciseEntry()
                                    {
                                        ExerciseID = (uint)y,
                                        CoDoExerciseID = (uint)z.ExerciseId,
                                    });
                                }
                            });
                        }
                    }

                    var trainData = mlContext.Data.LoadFromEnumerable(data);

                    MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
                    options.MatrixColumnIndexColumnName = nameof(ExerciseEntry.ExerciseID);
                    options.MatrixRowIndexColumnName = nameof(ExerciseEntry.CoDoExerciseID);
                    options.LabelColumnName = "Label";
                    options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
                    options.Alpha = 0.01;
                    options.Lambda = 0.025;
                    // For better results use the following parameters
                    options.NumberOfIterations = 100;
                    options.C = 0.00001;

                    var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);

                    model = est.Fit(trainData);
                }
            }
            


            var allExercises = _context.Exercises.Where(x => x.ExerciseId != id);

            var predictionResult = new List<Tuple<Database.Exercise, float>>();

            foreach (var exercise in allExercises)
            {
                var predictionEngine = mlContext.Model.CreatePredictionEngine<ExerciseEntry, Codo_prediction>(model);

                var prediction = predictionEngine.Predict(new ExerciseEntry()
                {
                    ExerciseID = (uint)id,
                    CoDoExerciseID = (uint)exercise.ExerciseId
                });

                predictionResult.Add(new Tuple<Database.Exercise, float>(exercise,prediction.Score));
            }

            var finalResult = predictionResult.OrderByDescending(x => x.Item2)
                .Select(x => x.Item1).Take(3).ToList();

            return _mapper.Map<List<Model.Exercise>>(finalResult);
        }


        public class Codo_prediction
        {
            public float Score { get; set; }
        }

        public class ExerciseEntry
        {
            [KeyType(count: 10)]
            public uint ExerciseID { get; set; }

            [KeyType(count: 10)]
            public uint CoDoExerciseID { get; set; }

            public float Label { get; set; }
        }
    }
}
