namespace RS2Seminarski.WebAPI.Database
{
    public class Plan
    {
        public int PlanId { get; set; }
        public string PlanName { get; set; } = null!;
        public string? Duration { get; set; }
        public int LevelId { get; set; }
        public virtual Level Level { get; set; } = null!;
        public string? About { get; set; }
        public string? Instruction { get; set; }

    }
}
