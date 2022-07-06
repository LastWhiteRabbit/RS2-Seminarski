using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model.Requests
{
    public class ExerciseInsertRequest
    {
        public string ExerciseName { get; set; }
        public int LevelId { get; set; }
        public string? Instruction { get; set; }
        public string? About { get; set; }
        public byte[]? ExerciseImage { get; set; }
        public List<int> ExerciseTypeIdList { get; set; } = new List<int> { };
        public List<int> MuscleIdList { get; set; } = new List<int> { };

    }
}
