using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AServiceLinkedTo
    {
        public AServiceLinkedTo()
        {
            BeneficiaryLinkageTrackingToolDirectMember = new HashSet<BeneficiaryLinkageTrackingToolDirectMember>();
            BeneficiaryLinkageTrackingToolIndirectMember = new HashSet<BeneficiaryLinkageTrackingToolIndirectMember>();
            BeneficiaryLinkageTrackingToolNew = new HashSet<BeneficiaryLinkageTrackingToolNew>();
        }

        public int ServiceLinkedToId { get; set; }
        public int? LinkageServiceCategoryId { get; set; }
        public string ServiceLinkedToDesc { get; set; }

        public virtual ALinkageServiceCategory LinkageServiceCategory { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingToolDirectMember> BeneficiaryLinkageTrackingToolDirectMember { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingToolIndirectMember> BeneficiaryLinkageTrackingToolIndirectMember { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingToolNew> BeneficiaryLinkageTrackingToolNew { get; set; }
    }
}
