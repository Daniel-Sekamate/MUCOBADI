using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuSafetyPlanningFormWarningSigns
    {
        public int WarningSignsId { get; set; }
        public int? SafetyPlanningFormId { get; set; }
        public string WarningSignsDescription { get; set; }
        public string WarningSignsNo { get; set; }

        public virtual SmuSafetyPlanningForm SafetyPlanningForm { get; set; }
    }
}
