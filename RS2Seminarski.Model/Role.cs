using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string? About { get; set; }

       // public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
