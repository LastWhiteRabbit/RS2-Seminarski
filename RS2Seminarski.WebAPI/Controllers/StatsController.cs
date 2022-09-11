using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RS2Seminarski.Model;
using RS2Seminarski.WebAPI.Interfaces;

namespace RS2Seminarski.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly IStatsService _service;

        public StatsController(IStatsService service)
        {
            _service = service;
        }

        [HttpGet("exercise-exercisetype")]
        public async Task<List<ChartResponse>> ExercisesPerType()
        {
            return await _service.exercisesPerType();
        }

        [HttpGet("exercise-exerciselevel")]
        public async Task<List<ChartResponse>> ExercisesPerLevel()
        {
            return await _service.exercisesPerLevel();
        }

        [HttpGet("exercise-exercisemuscle")]
        public async Task<List<ChartResponse>> ExercisesPerMuscle()
        {
            return await _service.exercisesPerMuscle();
        }
    }
}
