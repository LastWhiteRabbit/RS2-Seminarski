namespace RS2Seminarski.WebAPI.Database
{
    public class ExerciseType
    {
        public ExerciseType()
        {
            ExerciseExerciseTypes = new HashSet<ExerciseExerciseType>();
        }
        public int ExerciseTypeId { get; set; }
        public string ExerciseTypeName { get; set; } = null!;
        public virtual ICollection<ExerciseExerciseType> ExerciseExerciseTypes { get; set; }
    }
}
