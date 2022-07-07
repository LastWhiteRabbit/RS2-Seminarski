using RS2Seminarski.Model;
using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Controllers
{
    public class LevelController : BaseController<Model.Level, LevelSearchObject>
    {
        public LevelController(ILevelService service)
            : base(service)
        {
        }
    }
}
