using RS2Seminarski.Model;

namespace RS2Seminarski.WebAPI.Interfaces
{
    public interface IStatsService
    {
        Task<List<ChartResponse>> exercisesPerType();
        Task<List<ChartResponse>> exercisesPerMuscle();
        Task<List<ChartResponse>> exercisesPerLevel();
    }
}
