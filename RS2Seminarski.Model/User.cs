using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string UserName { get; set; }
        public bool? Status { get; set; }


        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
