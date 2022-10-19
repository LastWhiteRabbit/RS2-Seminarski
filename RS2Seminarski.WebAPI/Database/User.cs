using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.WebAPI.Database
{
    public class User
    {
        public User()
        {
            UserRoles = new HashSet<UserRole>();
            RoutineUsers = new HashSet<RoutineUser>();
        }
        public int UserId { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string UserName { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string PaswordSalt { get; set; } = null!;
        public bool? Status { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; } = null!;

        public int CityId { get; set; }
        public virtual City City { get; set; } = null!;

        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<RoutineUser> RoutineUsers { get; set; }

    }
}
