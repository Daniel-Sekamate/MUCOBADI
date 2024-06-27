using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuClientRegistrationForm
    {
        public SmuClientRegistrationForm()
        {
            SmuAssessmentGuide = new HashSet<SmuAssessmentGuide>();
        }

        public int ClientRegistrationFormId { get; set; }
        public int? DistrictId { get; set; }
        public int? RegionId { get; set; }
        public int? SmuOfficeId { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string SerialNumber { get; set; }
        public string SmuClientName { get; set; }
        public string ClientGenderId { get; set; }
        public int? ClientAgeRangeId { get; set; }
        public string ClientContact { get; set; }
        public int? SmuGroupId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CapturedBy { get; set; }
        public int? SubCountyId { get; set; }

        public virtual SmuAgeGroup ClientAgeRange { get; set; }
        public virtual AGender ClientGender { get; set; }
        public virtual SmuGroup SmuGroup { get; set; }
        public virtual ASubcounty SubCounty { get; set; }
        public virtual ICollection<SmuAssessmentGuide> SmuAssessmentGuide { get; set; }
    }
}
