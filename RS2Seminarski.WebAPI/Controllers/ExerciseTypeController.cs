using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Controllers
{
    public class ExerciseTypeController : BaseController<Model.ExerciseType, BaseSearchObject>
    {
        public ExerciseTypeController(IService<Model.ExerciseType, BaseSearchObject> service)
            : base(service)
        {
        }
    }
}
