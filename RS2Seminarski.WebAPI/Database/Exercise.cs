namespace RS2Seminarski.WebAPI.Database
{
    public class Exercise
    {
        public Exercise()
        {
            ExerciseExerciseTypes = new HashSet<ExerciseExerciseType>();
            ExerciseMuscles = new HashSet<ExerciseMuscle>();
            RoutineExercises = new HashSet<RoutineExercise>();
        }
        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; } = null!;
        public int LevelId { get; set; }
        public virtual Level Level { get; set; } = null!;
        public string? Instruction { get; set; }
        public string? About { get; set; }
        public byte[]? ExerciseImage { get; set; }

        public virtual ICollection<ExerciseExerciseType> ExerciseExerciseTypes { get; set; }
        public virtual ICollection<ExerciseMuscle> ExerciseMuscles { get; set; }
        public virtual ICollection<RoutineExercise> RoutineExercises { get; set; }



    }
}
