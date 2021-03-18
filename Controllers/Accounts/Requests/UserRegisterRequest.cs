using System;
using appointments_patients.Entities.UserInfo;
namespace appointments_patients.Controllers.Accounts.Requests 
{
    public class UserRegisterRequest {

        public IdDocumentType IdDocumentType {get; set; }
        public string IdDocument { get; set; }
        public string Name {get; set;}
        public string LastName {get; set; }
        public DateTime BithDate { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string PhonNumber { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}