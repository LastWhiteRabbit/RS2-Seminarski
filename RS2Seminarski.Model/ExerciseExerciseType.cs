using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model
{
    public class ExerciseExerciseType
    {
        public int ExerciseExerciseTypeId { get; set; }
        public int ExerciseId { get; set; }
        public int ExerciseTypeId { get; set; }

        public virtual ExerciseType ExerciseType { get; set; }
    }
}
