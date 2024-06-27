using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuSafetyPlanningFormPeopleProvideDistraction
    {
        public int PeopleProvideDistractionId { get; set; }
        public string PeopleProvideDistractionName { get; set; }
        public string PeopleProvideDistractionPhone { get; set; }
        public string PeopleProvideDistractionPlace { get; set; }
        public int? SafetyPlanningFormId { get; set; }
        public string PeopleProvideDistractionNo { get; set; }

        public virtual SmuSafetyPlanningForm SafetyPlanningForm { get; set; }
    }
}
