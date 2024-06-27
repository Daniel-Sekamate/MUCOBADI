using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewVlrVlcVlsDashboard
    {
        public int HivTbTrackingFormId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public string Qtr { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? SubcountyId { get; set; }
        public string SubcountyDescription { get; set; }
        public int? FollowUpDateYear { get; set; }
        public int? FollowUpDateMonth { get; set; }
        public int? IsClientEligibleForViralload { get; set; }
        public int? ViralloadTestDone { get; set; }
        public int? ViralloadResultsReceived { get; set; }
        public string ViralLoadDescription { get; set; }
        public string ViralloadTestResults { get; set; }
        public int? ViralLoadSuppressedId { get; set; }
        public string ViralLoadSuppressedDescription { get; set; }
        public DateTime? DoB { get; set; }
        public int? ActualAge { get; set; }
        public string AgeCategory { get; set; }
    }
}
