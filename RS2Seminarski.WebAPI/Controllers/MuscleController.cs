using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Controllers
{
    public class MuscleController : BaseController<Model.Muscle, BaseSearchObject>
    {
        public MuscleController(IService<Model.Muscle, BaseSearchObject> service)
            : base(service)
        {
        }
    }
}
