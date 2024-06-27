namespace MUCOBADI.DTOs.Dashboard
{
	public class HeatMapData
	{
		public string[] XLabels = new string[] { "F", "M", "F", "M", "F", "M", "F", "M", "F", "M", "F", "M", "F", "M", "F", "M", "Total" };
		public string[] YLabels = new string[] { "SHE Leads", "ICARE", "YAW", "Global Fund" };
		//public string XLabel { get; set; }
		//public string YLabel { get; set; }
		public double? Value { get; set; }
	}
}
