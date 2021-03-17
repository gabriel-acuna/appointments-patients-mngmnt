using System;
namespace appointments_patients.Models.Account

{
    public class Role {
        public Guid Id {get;set;}
        public ERole Name {get; set;}

    }
    public enum ERole
    {
        Admin,
        Professional,
        Patient
    }
}