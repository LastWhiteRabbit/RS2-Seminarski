using RS2Seminarski.Model;
using RS2Seminarski.Model.Requests;
using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Controllers
{
    public class ExerciseController : BaseCRUDController<Exercise, ExerciseSearchObject, ExerciseInsertRequest, ExerciseUpdateRequest>
    {
        public ExerciseController(IExerciseService service)
            : base(service)
        {
        }

    }
}
