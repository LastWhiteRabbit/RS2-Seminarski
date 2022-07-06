using RS2Seminarski.Model.Requests;
using RS2Seminarski.Model.SearchObjects;

namespace RS2Seminarski.WebAPI.Interfaces
{
    public interface IRoutineService : ICRUDService<Model.Routine, RoutineSearchObject, RoutineInsertRequest, RoutineUpdateRequest>
    {
    }
}
