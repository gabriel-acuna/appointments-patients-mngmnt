using appointments_patients.Controllers.Accounts.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace appointments_patients.Controllers.Accounts
{
    [Route("api/[controller]")]
    [ApiController]
    public class TennatRegisterController : ControllerBase
    {
        
        // POST api/<ValuesController>
        [HttpPost]
        public TennatRegisterRequest Post(TennatRegisterRequest tennat)
        {
            return tennat;
        }

       
    }
}
