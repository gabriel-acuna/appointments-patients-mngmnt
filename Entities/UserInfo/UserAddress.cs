using System;

namespace appointments_patients.Entities.UserInfo
{
    public class UserAddress
    {
        public Guid Id { get; set;}
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
