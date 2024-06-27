using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuViewClientRegistrationForm
    {
        public int ClientRegistrationFormId { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? RegionId { get; set; }
        public string RegionDescription { get; set; }
        public int? SmuOfficeId { get; set; }
        public string OfficeName { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string SerialNumber { get; set; }
        public string SmuClientName { get; set; }
        public string ClientGenderId { get; set; }
        public int? ClientAgeRangeId { get; set; }
        public string AgeGroup { get; set; }
        public string ClientContact { get; set; }
        public int? SmuGroupId { get; set; }
        public string SmuGroupName { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? SubCountyId { get; set; }
        public string SubcountyDescription { get; set; }
        public int? SmuFacilitatorId { get; set; }
        public string SmuFacilitatorName { get; set; }
    }
}
