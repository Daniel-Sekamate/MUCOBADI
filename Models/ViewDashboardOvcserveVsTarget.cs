using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardOvcserveVsTarget
    {
        public long? RowNum { get; set; }
        public string HouseHoldMemberCode { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? SubcountyId { get; set; }
        public string SubcountyDescription { get; set; }
        public int? VisitationYear { get; set; }
        public int? Qtr { get; set; }
        public int? ProgramParticipationId { get; set; }
        public int? ActualAge { get; set; }
        public string AgeCategory { get; set; }
        public int? HivstatusId { get; set; }
        public string HivstatusDescription { get; set; }
        public int? IsCareGiver { get; set; }
        public DateTime? VisitationDate { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public int? IsGraduated { get; set; }
        public int? GraduationYear { get; set; }
        public int? GraduationQtr { get; set; }
    }
}
