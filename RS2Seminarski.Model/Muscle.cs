using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model
{
    public class Muscle
    {
        public int MuscleId { get; set; }
        public string MuscleName { get; set; } = null!;

        //public virtual ICollection<ExerciseMuscle> ExerciseMuscles { get; set; }
    }
}
