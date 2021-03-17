using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appointments_patients.Controllers.Accounts.Requests
{
    public class TennatRegisterRequest
    {
        public string Subdomain { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
