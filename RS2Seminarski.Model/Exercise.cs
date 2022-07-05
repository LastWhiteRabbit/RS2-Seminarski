using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public int LevelId { get; set; }
        public string? Instruction { get; set; }
        public string? About { get; set; }
        public byte[]? ExerciseImage { get; set; }

        //public virtual ICollection<ExerciseExerciseType> ExerciseExerciseTypes { get; set; }
        //public virtual ICollection<ExerciseMuscle> ExerciseMuscles { get; set; }
       // public virtual ICollection<RoutineExercise> RoutineExercises { get; set; }
    }
}
