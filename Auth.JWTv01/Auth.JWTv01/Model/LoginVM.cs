using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.JWTv01.Model
{
    public class LoginVM
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
