using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardGraduationBenchMark
    {
        public int? HouseholdId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public int IsGraduated { get; set; }
    }
}
