using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Controllers
{
    public class PlanController : BaseController<Model.Plan, object>
    {
        public PlanController(IService<Model.Plan, object> service)
            : base(service)
        {
        }
    }
}
