using System;

namespace appointments_patients.Models.Tennat
{
   

    public class TennatSubscription
    {
        public Guid Id { get; set; }
        public  virtual Tennat Tennat {get; set;}
        public virtual Subscription Subscription { get; set; }
        public DateTime Start {get;set;}

        public DateTime End {get;set;}
        public bool isActive {get;set;}

        
    }
}