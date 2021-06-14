using System;
using appointments_patients.Entities.UserInfo;

namespace appointments_patitens.Entities.ClinicalRecord
{

    public class MedicalHistory{
        public Guid Id;
        public UserProfile User;
        public PathologicalPersonalHistory PPH;
        public PathologicalFamilyHistory PFH;
        
    }
}