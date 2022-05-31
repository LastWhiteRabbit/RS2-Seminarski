namespace RS2Seminarski.WebAPI.Database
{
    public class RoutineUser
    {
        public int RoutineUserId { get; set; }
        public int RoutineId { get; set; }
        public int UserId { get; set; }

        public virtual Routine Routine { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
