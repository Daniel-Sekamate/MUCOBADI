using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class BeneficiaryLinkageTrackingToolIndirectMember
    {
        public int LinkageTrackingToolIndirectMemberId { get; set; }
        public int LinkageTrackingToolId { get; set; }
        public int? VslaGroupIndirectMemberId { get; set; }
        public int? ServiceLinkedToId { get; set; }
        public int? ServiceReceived { get; set; }
        public string IteamCost { get; set; }
        public string ServiceRecievedDetail { get; set; }

        public virtual BeneficiaryLinkageTrackingTool LinkageTrackingTool { get; set; }
        public virtual AServiceLinkedTo ServiceLinkedTo { get; set; }
        public virtual AYesNo ServiceReceivedNavigation { get; set; }
        public virtual VslaGroupIndirectMember VslaGroupIndirectMember { get; set; }
    }
}
