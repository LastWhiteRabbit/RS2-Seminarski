namespace RS2Seminarski.WebAPI.Database
{
    public class Routine
    {
        public Routine()
        {
            RoutineExercises = new HashSet<RoutineExercise>();
            RoutineUsers = new HashSet<RoutineUser>();
        }
        public int RoutineId { get; set; }
        public string RoutineName { get; set; } = null!;
        public string? Description { get; set; }
        public int? Rating { get; set; }

        public virtual ICollection<RoutineExercise> RoutineExercises { get; set; }
        public virtual ICollection<RoutineUser> RoutineUsers { get; set; }

    }
}
