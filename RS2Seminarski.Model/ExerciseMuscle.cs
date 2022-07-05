using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model
{
    public class ExerciseMuscle
    {
        public int ExerciseMuscleId { get; set; }
        public int ExerciseId { get; set; }
        public int MuscleId { get; set; }

        public virtual Muscle Muscle { get; set; }
    }
}
