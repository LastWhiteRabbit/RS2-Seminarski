using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RS2Seminarski.Model;
using RS2Seminarski.Model.Requests;
using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController
        : BaseCRUDController<User, UserSearchObject, UserInsertRequest, UserUpdateRequest>
    {
        public UserController(IUserService service)
            : base(service)
        {
        }


        //[Authorize("Administrator")]
        public override Task<User> Update(int id, [FromBody] UserUpdateRequest update)
        {
            return base.Update(id, update);
        }

        [AllowAnonymous]
        public override Task<User> Insert([FromBody] UserInsertRequest insert)
        {
            return base.Insert(insert);
        }
    }
}
