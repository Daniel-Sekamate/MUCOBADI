using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class CaseCareDetailPlan
    {
        public int CaseCareDetailPlanId { get; set; }
        public int? CaseCareDetailsId { get; set; }
        public int? PriorityAreaId { get; set; }
        public string CasePlanGoal { get; set; }
        public string PriorityAreaCodeId { get; set; }
        public string RefferalPriorityAreaCodeId { get; set; }
        public DateTime? ActionCompletionPlannedDate { get; set; }
        public DateTime? ActionCompletionActualDate { get; set; }
        public string ResponsiblePerson { get; set; }
        public int? CasePlanStausId { get; set; }

        public virtual CaseCareDetail CaseCareDetails { get; set; }
        public virtual ACasePlanStaus CasePlanStaus { get; set; }
        public virtual APriorityArea PriorityArea { get; set; }
    }
}
