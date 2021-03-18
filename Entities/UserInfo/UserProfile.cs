using System;
using System.Collections.Generic;
using appointments_patients.Entities.Account;
namespace appointments_patients.Entities.UserInfo
{
   
    public class UserProfile
    {
        public Guid Id {get; set;}
        public string Name {get; set;}
        public string LastName {get; set; }
        public DateTime BirthDate { get; set; }
        public IdDocumentType IdDocumentType {get; set; }
        public string IdDocument { get; set; }
        public string PhonNumber { get; set; }
        public UserAccount  UserAccount { get; set;}
        public UserAddress Address { get; set; }


        public Dictionary<string, int> GetAge ()
        {
            DateTime today = DateTime.Now;
            TimeSpan dif = today.Subtract(BirthDate);
            int years = today.Year - BirthDate.Year;
            int months = today.Month - BirthDate.Month;
            int days = today.Day - BirthDate.Day;
           
            if (months < 0 ){
               years --;
               
             
            }  if (today.Day < BirthDate.Day){
                  days = DateTime.DaysInMonth(BirthDate.Year, BirthDate.Month) - BirthDate.Day + DateTime.Now.Day;
                  months = BirthDate.Month - today.Month  -1;
            }
            
            return  new Dictionary<string, int>(){
                {"Years", years},
                {"Months", months},
                {"Days",  days}
        };
        }

    }
}