using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using appointments_patients.Models.Account;

namespace appointments_patients.Data
{
    public class AppointmentsPatientsContext : DbContext
    {
        public AppointmentsPatientsContext (DbContextOptions<AppointmentsPatientsContext> options)
            : base(options)
        {
        }

        public DbSet<appointments_patients.Models.Account.Role> Role { get; set; }
        public DbSet<appointments_patients.Models.Account.UserAccount> UserAccounts { get; set; }
    }
}
