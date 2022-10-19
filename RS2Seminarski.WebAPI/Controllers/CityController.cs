using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Controllers
{
    public class CityController : BaseController<Model.City, object>
    {
        public CityController(IService<Model.City, object> service)
            : base(service)
        {
        }
    }
}
