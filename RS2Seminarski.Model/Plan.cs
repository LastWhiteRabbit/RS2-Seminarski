using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model
{
    public class Plan
    {
        public int PlanId { get; set; }
        public string PlanName { get; set; } = null!;
        public string? Duration { get; set; }
        public int LevelId { get; set; }
        public string? About { get; set; }
        public string? Instruction { get; set; }
    }
}
