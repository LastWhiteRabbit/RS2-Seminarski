using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model
{
    public class RoutineUser
    {
        public int RoutineUserId { get; set; }
        public int RoutineId { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
