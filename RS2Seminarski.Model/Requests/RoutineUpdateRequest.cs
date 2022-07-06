using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model.Requests
{
    public class RoutineUpdateRequest
    {
        public string RoutineName { get; set; }
        public string? Description { get; set; }
    }
}
