using System;

namespace MUCOBADI.DTOs.Dashboard
{
	public class StakeholdersData
	{
		public int? IndicatorId { get; set; }
		public string DistrictId { get; set; }
		public string ProjectId { get; set; }
		public string QuarterId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string Project { get; set; }
		public double? Female_Under_One_Year { get; set; }
		public double? Male_Under_One_Year { get; set; }
		public double? Female_1_4 { get; set; }
		public double? Male_1_4 { get; set; }
		public double? Female_5_9 { get; set; }
		public double? Male_5_9 { get; set; }
		public double? Female_10_14 { get; set; }
		public double? Male_10_14 { get; set; }
		public double? Female_15_17 { get; set; }
		public double? Male_15_17 { get; set; }
		public double? Female_18_24 { get; set; }
		public double? Male_18_24 { get; set; }
		public double? Female_25_Plus { get; set; }
		public double? Male_25_Plus { get; set; }
		public double? FemaleSum { get; set; }
		public double? MaleSum { get; set; }
		public double? TotalReached { get; set; }
		public double? Target { get; set; }
		public double? PercentageAchived { get; set; }
		public double?  percentageAdoloscent { get; set; }
		public double? totalAdoloscent { get; set; }
	}
}
