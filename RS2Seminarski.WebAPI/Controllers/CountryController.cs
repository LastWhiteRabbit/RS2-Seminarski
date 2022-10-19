using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Controllers
{
    public class CountryController : BaseController<Model.Country, object>
    {
        public CountryController(IService<Model.Country, object> service)
            : base(service)
        {
        }
    }
}
