using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuTerminantionGuide
    {
        public SmuTerminantionGuide()
        {
            SmuTerminantionGuidePh9Questions = new HashSet<SmuTerminantionGuidePh9Questions>();
        }

        public int SmuTerminantionGuideId { get; set; }
        public int? SmuOfficeId { get; set; }
        public int? RegionId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubCountyId { get; set; }
        public int? SmuProgramId { get; set; }
        public int? SmuGroupId { get; set; }
        public DateTime? DateOfAssessment { get; set; }
        public int? ClientRegistrationId { get; set; }
        public int? LevelOfDifficultyId { get; set; }
        public int? EncourageFriendsFamily { get; set; }
        public string NameOfVolunter { get; set; }
        public string RespondantGenderId { get; set; }
        public int? RespondantAge { get; set; }
        public double? OverallPh9Score { get; set; }

        public virtual SmuLevelOfDifficultyToCheckOffProblems LevelOfDifficulty { get; set; }
        public virtual SmuGroup SmuGroup { get; set; }
        public virtual ICollection<SmuTerminantionGuidePh9Questions> SmuTerminantionGuidePh9Questions { get; set; }
    }
}
