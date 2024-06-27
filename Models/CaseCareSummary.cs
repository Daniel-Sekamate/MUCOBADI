using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class CaseCareSummary
    {
        public int CaseCareSummaryId { get; set; }
        public int CaseCareId { get; set; }
        public int HouseHoldMemberId { get; set; }
        public string RefferalServiceReceivedId { get; set; }
        public string OrganisationName { get; set; }
        public string AgencyContact { get; set; }

        public virtual CaseCare CaseCare { get; set; }
        public virtual HouseHoldMembers HouseHoldMember { get; set; }
    }
}
