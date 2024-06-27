using System;

namespace MUCOBADI.DTOs
{
    public class EnrolmentSearchModel
    {
        public int[]? DistrictId { get; set; }
        public int[]? SubcountyId { get; set; }
        public int[]? HouseholdId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
