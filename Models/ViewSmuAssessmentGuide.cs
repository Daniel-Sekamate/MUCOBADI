using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewSmuAssessmentGuide
    {
        public int AssementGuideId { get; set; }
        public string RespondantGenderId { get; set; }
        public string GenderDescription { get; set; }
        public int? RespondantAge { get; set; }
        public string AgeGroup { get; set; }
        public int? SubCountyId { get; set; }
        public string SubcountyDescription { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? RegionId { get; set; }
        public string RegionDescription { get; set; }
        public int? SmuGroupId { get; set; }
        public int? ClientRegistrationId { get; set; }
        public string SmuClientName { get; set; }
        public string ClientContact { get; set; }
    }
}
