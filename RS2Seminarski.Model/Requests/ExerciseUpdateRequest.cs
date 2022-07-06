using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model.Requests
{
    public class ExerciseUpdateRequest
    {
        public string ExerciseName { get; set; }
        public string? Instruction { get; set; }
        public string? About { get; set; }
    }
}
