using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RS2Seminarski.Model;
using RS2Seminarski.Model.Requests;
using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController
        : BaseCRUDController<WeatherForecast, WeatherForecastSearchObject, WeatherForecastInsertRequest, WeatherForecastUpdateRequest>
    {
        public WeatherForecastController(IWeatherForecastService service)
            : base(service)
        {
        }
    }
}
