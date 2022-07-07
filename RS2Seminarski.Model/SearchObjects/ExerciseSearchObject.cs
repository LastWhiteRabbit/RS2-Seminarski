using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model.SearchObjects
{
    public class ExerciseSearchObject : BaseSearchObject
    {
        public string? ExerciseName { get; set; }
        public int LevelId { get; set; }
    }
}
