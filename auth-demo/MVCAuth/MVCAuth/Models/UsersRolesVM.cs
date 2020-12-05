using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuth.Models
{
    public class UsersRolesVM
    {
        //public string UserName { get; set; }
        public ApplicationUser User { get; set; }

        public IEnumerable<string> RoleNames { get; set; }
    }
}