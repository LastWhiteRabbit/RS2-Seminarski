using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model
{
    public class RoutineExercise
    {
        public int RoutineExerciseId { get; set; }
        public int RoutineId { get; set; }
        public int ExerciseId { get; set; }

        public virtual Exercise Exercise { get; set; }
    }
}
