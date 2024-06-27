using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuViewAttendenceHeader
    {
        public int AttendenceFormHeaderId { get; set; }
        public int? SmuGroupId { get; set; }
        public string SmuGroupName { get; set; }
        public int? RegionId { get; set; }
        public string RegionDescription { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? SubcountyId { get; set; }
        public string SubcountyDescription { get; set; }
        public int? SmuFacilitatorId { get; set; }
        public string SmuFacilitatorName { get; set; }
        public int? SmuOfficeId { get; set; }
        public string OfficeName { get; set; }
        public int? AttendenceYearId { get; set; }
        public string FinancialYearDesc { get; set; }
        public int? AttendenceCycleId { get; set; }
        public string CycleDescription { get; set; }
        public DateTime? SessionOneDate { get; set; }
        public DateTime? SessionTwoDate { get; set; }
        public DateTime? SessionThreeDate { get; set; }
        public DateTime? SessionFourDate { get; set; }
        public DateTime? SessionFiveDate { get; set; }
        public DateTime? SessionSixDate { get; set; }
    }
}
