using System;
using System.Collections.Generic;

namespace appointments_patitens.Entities.ClinicalRecord
{

    public class PathologicalPersonalHistory {
        public Guid Id;
        public MedicalHistory MedicalHistory;
        public List<Allergy> Allergies;
        public List<PersonalDisease> PersonalDiseases;
        public List<Surgery> Surgeries;
        
    }
}