using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuSafetyPlanningFormInternalCopingStrategies
    {
        public int InternalCopingStrategiesId { get; set; }
        public string InternalCopingStrategies { get; set; }
        public int? SafetyPlanningFormId { get; set; }
        public string InternalCopingStrategiesNo { get; set; }
        public bool? IsPlaceholder { get; set; }

        public virtual SmuSafetyPlanningForm SafetyPlanningForm { get; set; }
    }
}
