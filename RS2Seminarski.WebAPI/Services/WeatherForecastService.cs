using AutoMapper;
using RS2Seminarski.Model.Requests;
using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WebAPI.Database;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Services
{
    public class WeatherForecastService :
        BaseCRUDService<Model.WeatherForecast, Database.WeatherForecast, WeatherForecastSearchObject, WeatherForecastInsertRequest, WeatherForecastUpdateRequest>, IWeatherForecastService
    {
        public WeatherForecastService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<WeatherForecast> AddFilter(IQueryable<WeatherForecast> query, WeatherForecastSearchObject? search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search?.TemperatureC != null)
            {
                filteredQuery = filteredQuery.Where(x => x.TemperatureC == search.TemperatureC);
            }

            return filteredQuery;
        }
    }
}
