using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RS2Seminarski.Model;
using RS2Seminarski.Model.Requests;
using RS2Seminarski.Model.SearchObjects;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Controllers
{
    [AllowAnonymous]
    public class ExerciseController : BaseCRUDController<Exercise, ExerciseSearchObject, ExerciseInsertRequest, ExerciseUpdateRequest>
    {
        public IExerciseService ExerciseService { get; set; }
        public ExerciseController(IExerciseService service)
            : base(service)
        {
            ExerciseService = service;
        }

        [HttpGet("{id}/Recommend")]
        public async Task <List<Exercise>> Recommend(int id)
        {
            return await ExerciseService.Recommend(id);
        }

    }
}
