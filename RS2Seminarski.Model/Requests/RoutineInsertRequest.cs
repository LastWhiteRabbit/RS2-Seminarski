using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model.Requests
{
    public class RoutineInsertRequest
    {
        public string RoutineName { get; set; }
        public string? Description { get; set; }
        public List<int> ExerciseIdList { get; set; } = new List<int> { };
    }
}
