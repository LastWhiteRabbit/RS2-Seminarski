using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model
{
    public class Routine
    {
        public int RoutineId { get; set; }
        public string RoutineName { get; set; } = null!;
        public string? Description { get; set; }
        public int? Rating { get; set; }

        //public virtual ICollection<RoutineExercise> RoutineExercises { get; set; }
        //public virtual ICollection<RoutineUser> RoutineUsers { get; set; }
    }
}
