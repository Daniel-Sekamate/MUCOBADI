using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuSafetyPlanningFormProfessionsAgenciesToContact
    {
        public int ProfessionalsAgenciesToContactDuringCrisisId { get; set; }
        public string ClinicianName { get; set; }
        public string ClinicianPhoneNumber { get; set; }
        public string NameOfClinic { get; set; }
        public string LocalUrgentCareServices { get; set; }
        public string UrgentCareServicesAddress { get; set; }
        public string UrgentCareServicesPhone { get; set; }
        public int? SafetyPlanningFormId { get; set; }
        public string ProfessionalsAgenciesToContactDuringCrisisNo { get; set; }

        public virtual SmuSafetyPlanningForm SafetyPlanningForm { get; set; }
    }
}
