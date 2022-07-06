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
            CreateMap<Database.Exercise, Model.Exercise>();
            CreateMap<Database.Routine, Model.Routine>();


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
