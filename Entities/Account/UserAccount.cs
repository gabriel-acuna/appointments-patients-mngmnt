using System;
using System.Collections.Generic;
using appointments_patients.Entities.UserInfo;

namespace appointments_patients.Entities.Account
{
    public class UserAccount
    {
        public UserAccount() => Roles = new HashSet<Role>();

        public Guid Id {get;set;}
        public Guid TennantId {get; set;}

        public String Email {get;set;}
        public String HashedPassword {get;set;}
        public bool isTennat {get; set; }
        public bool isActive {get; set; }
        public virtual ICollection<Role> Roles {get; set; }
        public  UserProfile UserProfile {get; set; }
    }
}
