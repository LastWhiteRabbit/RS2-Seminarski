namespace RS2Seminarski.WebAPI.Database
{
    public class ExerciseMuscle
    {
        public int ExerciseMuscleId { get; set; }
        public int ExerciseId { get; set; }
        public int MuscleId { get; set; }

        public virtual Exercise Exercise { get; set; } = null!;
        public virtual Muscle Muscle { get; set; } = null!;


    }
}
