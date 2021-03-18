using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using appointments_patients.Entities.Account;

namespace appointments_patients.Data
{
    public class AppointmentsPatientsContext : DbContext
    {
        public AppointmentsPatientsContext (DbContextOptions<AppointmentsPatientsContext> options)
            : base(options)
        {
        }

        public DbSet<Role> Role { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
    }
}
