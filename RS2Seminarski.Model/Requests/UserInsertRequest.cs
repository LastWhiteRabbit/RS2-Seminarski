using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model.Requests
{
    public class UserInsertRequest
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        [Required(AllowEmptyStrings = false)]
        [EmailAddress()]
        public string Email { get; set; }
        public string Mobile { get; set; }

        [MinLength(4)]
        [Required(AllowEmptyStrings = false)]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public bool? Status { get; set; }


        public List<int> RoleIdList { get; set; } = new List<int> { };
        public List<int> RoutineIdList { get; set; } = new List<int> { };
    }
}
