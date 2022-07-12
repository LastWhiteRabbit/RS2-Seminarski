using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Controllers
{
    public class RoleController : BaseController<Model.Role, BaseSearchObject>
    {
        public RoleController(IService<Model.Role,BaseSearchObject> service)
            : base(service)
        {
        }
    }
}
