namespace RS2Seminarski.WebAPI.Database
{
    public class RoutineExercise
    {
        public int RoutineExerciseId { get; set; }
        public int RoutineId { get; set; }
        public int ExerciseId { get; set; }

        public virtual Routine Routine { get; set; } = null!;
        public virtual Exercise Exercise { get; set; } = null!;
    }
}
