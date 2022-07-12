using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS2Seminarski.Model.SearchObjects
{
    public class UserSearchObject : BaseSearchObject
    {
        public string? Name { get; set; }
        public string? UserName { get; set; }

        public string? Email { get; set; }

        public bool IncludeRoles { get; set; }

    }
}
