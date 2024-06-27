using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuSucideAssementFormHeader
    {
        public int SucideAssessmentFormHeaderId { get; set; }
        public int? SucideAssementResponseId { get; set; }
        public int? SucideAssementQuestionId { get; set; }
        public int? AssementGuideId { get; set; }
        public int? SmuGroupId { get; set; }
        public double? SuicideAssesmentScore { get; set; }
        public int? ClientRegistrationId { get; set; }
        public int? DistrictId { get; set; }
        public int? RegionId { get; set; }
        public int? SmuOfficeId { get; set; }

        public virtual SmuAssessmentGuide AssementGuide { get; set; }
        public virtual SmuSucideAssementQuestion SucideAssementQuestion { get; set; }
        public virtual SmuSucideAssementResponse SucideAssementResponse { get; set; }
    }
}
