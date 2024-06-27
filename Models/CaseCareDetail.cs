using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class CaseCareDetail
    {
        public CaseCareDetail()
        {
            CaseCareDetailPlan = new HashSet<CaseCareDetailPlan>();
        }

        public int CaseCareDetailsId { get; set; }
        public int? CaseCareId { get; set; }
        public int? CasePlanId { get; set; }
        public int? HouseHoldMemberId { get; set; }

        public virtual CaseCare CaseCare { get; set; }
        public virtual ACasePlan CasePlan { get; set; }
        public virtual HouseHoldMembers HouseHoldMember { get; set; }
        public virtual ICollection<CaseCareDetailPlan> CaseCareDetailPlan { get; set; }
    }
}
