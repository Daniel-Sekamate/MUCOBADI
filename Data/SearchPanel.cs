using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MUCOBADI.Data
{
    public class SearchPanel
    {
        public int?[] DistrictId { get; set; }
        public int?[] SubcountyId { get; set; }
        public int?[] ParishId { get; set; }
        public int?[] VillageId { get; set; }
        public int? QuarterId { get; set; }
        public int? YearId { get; set; }
        public int? GroupId { get; set; }
        public int? GroupCycleId { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? IsDueForArtRefill { get; set; }
        public int? IsDueForViralload { get; set; }
		public int?[] DashboardQuarterId { get; set; }
		public int?[] DashboardYear { get; set; }
	}
}
