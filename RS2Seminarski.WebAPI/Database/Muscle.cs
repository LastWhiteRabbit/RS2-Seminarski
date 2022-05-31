namespace RS2Seminarski.WebAPI.Database
{
    public class Muscle
    {
        public Muscle()
        {
            ExerciseMuscles = new HashSet<ExerciseMuscle>();
        }
        public int MuscleId { get; set; }
        public string MuscleName { get; set; } = null!;

        public virtual ICollection<ExerciseMuscle> ExerciseMuscles { get; set; }

    }
}
