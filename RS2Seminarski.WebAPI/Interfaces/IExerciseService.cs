using RS2Seminarski.Model.Requests;
using RS2Seminarski.Model.SearchObjects;

namespace RS2Seminarski.WebAPI.Interfaces
{
    public interface IExerciseService : ICRUDService<Model.Exercise, ExerciseSearchObject, ExerciseInsertRequest, ExerciseUpdateRequest>
    {
    }
}
