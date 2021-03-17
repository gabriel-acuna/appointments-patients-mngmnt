using System;
using System.Collections.Generic;

namespace appointments_patients.Models.Account
{
    public class UserAccount
    {
        public UserAccount() => Roles = new HashSet<Role>();

        public Guid Id {get; set;}
        public Guid TennantId {get; set;}

        public String Email {get;set;}
        public String HashedPassword {get;set;}

        public virtual ICollection<Role> Roles {get; set; }
    }
}
