using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuPreGroupGuide
    {
        public SmuPreGroupGuide()
        {
            SmuPreGroupGuidePh9Questions = new HashSet<SmuPreGroupGuidePh9Questions>();
        }

        public int SmuPreGroupGuideId { get; set; }
        public int? SmuOfficeId { get; set; }
        public int? RegionId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubCountyId { get; set; }
        public int? SmuProgramId { get; set; }
        public int? SmuGroupId { get; set; }
        public DateTime? DateOfAssessment { get; set; }
        public int? ClientRegistrationId { get; set; }
        public string NameOfVolunter { get; set; }
        public string RespondantGenderId { get; set; }
        public int? RespondantAge { get; set; }
        public int? MaritalStatusId { get; set; }
        public int? NationalityId { get; set; }
        public int? ResidencyStatusId { get; set; }
        public string SchoolName { get; set; }
        public int? SchoolClassId { get; set; }
        public string PrisionName { get; set; }
        public int? LevelOfDifficultyId { get; set; }
        public double? OverallPh9Score { get; set; }
        public int? VillageId { get; set; }

        public virtual AMaritalStatus MaritalStatus { get; set; }
        public virtual SmuResidency ResidencyStatus { get; set; }
        public virtual SmuGroup SmuGroup { get; set; }
        public virtual ICollection<SmuPreGroupGuidePh9Questions> SmuPreGroupGuidePh9Questions { get; set; }
    }
}
