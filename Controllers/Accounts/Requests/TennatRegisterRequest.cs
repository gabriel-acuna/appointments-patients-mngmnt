using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace appointments_patients.Controllers.Accounts.Requests
{
    public class TennatRegisterRequest
    {
        public string Subdomain { get; set; }
        public UserRegisterRequest UserRegisterRequest {get; set; }
    }
}
