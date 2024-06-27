using StackExchange.Redis;
using System.Collections.Generic;

namespace MUCOBADI.DTOs.Dashboard
{
    public class DistrictSubcounty
    {
        public string TotalHouseHolds { get; set; }
        public string DistrictDescription { get; set; }
		public IEnumerable<SubcountyDetails> CountyDetails { get; set; }
	}

    public class SubcountyDetails
    {
        public int DistrictId { get; set; }
		public string DistrictDescription { get; set; }
		public string SubcountyDescription { get; set; }
		public double VisitedOnce { get; set; }
		public double VisitedTwice { get; set; }
		public double VisitedThrice { get; set; }
        public double PercentageVisited { get; set; }
    }
}
