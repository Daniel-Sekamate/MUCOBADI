using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class IsvatincomeEarner
    {
        public IsvatincomeEarner()
        {
            IsvatincomeOwnership = new HashSet<IsvatincomeOwnership>();
        }

        public int IsvatincomeEarnerId { get; set; }
        public int? IsvatheaderId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public int? IncomeEarnerYesNoId { get; set; }

        public virtual HouseHoldMembers HouseHoldMember { get; set; }
        public virtual AYesNo IncomeEarnerYesNo { get; set; }
        public virtual Isvatheader Isvatheader { get; set; }
        public virtual ICollection<IsvatincomeOwnership> IsvatincomeOwnership { get; set; }
    }
}
