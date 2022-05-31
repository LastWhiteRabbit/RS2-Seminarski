namespace RS2Seminarski.WebAPI.Database
{
    public class ExerciseExerciseType
    {
        public int ExerciseExerciseTypeId { get; set; }
        public int ExerciseId { get; set; }
        public int ExerciseTypeId { get; set; }

        public virtual Exercise Exercise { get; set; } = null!;
        public virtual ExerciseType ExerciseType { get; set; } = null!;
    }
}
