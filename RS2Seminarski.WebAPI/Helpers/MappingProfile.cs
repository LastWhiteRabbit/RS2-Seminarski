using AutoMapper;
using RS2Seminarski.Model.Requests;

namespace RS2Seminarski.WebAPI.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Database.WeatherForecast, Model.WeatherForecast>();
            CreateMap<Database.User, Model.User>();
            CreateMap<Database.UserRole, Model.UserRole>();
            CreateMap<Database.Role, Model.Role>();
            CreateMap<Database.Exercise, Model.Exercise>();
            CreateMap<Database.ExerciseMuscle, Model.ExerciseMuscle>();
            CreateMap<Database.Muscle, Model.Muscle>();
            CreateMap<Database.ExerciseExerciseType, Model.ExerciseExerciseType>();
            CreateMap<Database.ExerciseType, Model.ExerciseType>();
            CreateMap<Database.Routine, Model.Routine>();
            CreateMap<Database.RoutineExercise, Model.RoutineExercise>();
            CreateMap<Database.Level, Model.Level>();
            CreateMap<Database.Country, Model.Country>();
            CreateMap<Database.City, Model.City>();
            CreateMap<Database.Plan, Model.Plan>();


            CreateMap<WeatherForecastInsertRequest, Database.WeatherForecast>();
            CreateMap<WeatherForecastUpdateRequest, Database.WeatherForecast>();

            CreateMap<UserInsertRequest, Database.User>();
            CreateMap<UserUpdateRequest, Database.User>();

            CreateMap<ExerciseInsertRequest, Database.Exercise>();
            CreateMap<ExerciseUpdateRequest, Database.Exercise>();

            CreateMap<RoutineInsertRequest, Database.Routine>();
            CreateMap<RoutineUpdateRequest, Database.Routine>();
        }
    }
}
