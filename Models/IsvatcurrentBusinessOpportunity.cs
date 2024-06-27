using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class IsvatcurrentBusinessOpportunity
    {
        public int IsvatcurrentBusinessOpportunityId { get; set; }
        public int? IsvatheaderId { get; set; }
        public int? CurrenBusinessOpportunityId { get; set; }
        public string OtherCurrenBusinessOpportunity { get; set; }
        public int? YesNoId { get; set; }

        public virtual ACurrenBusinessOpportunity CurrenBusinessOpportunity { get; set; }
        public virtual Isvatheader Isvatheader { get; set; }
        public virtual AYesNo YesNo { get; set; }
    }
}
