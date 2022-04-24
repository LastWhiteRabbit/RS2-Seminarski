using RS2Seminarski.Model.Requests;
using RS2Seminarski.Model.SearchObjects;

namespace RS2Seminarski.WebAPI.Interfaces
{
    public interface IUserService : ICRUDService<Model.User, UserSearchObject, UserInsertRequest, UserUpdateRequest>
    {
    }
}
