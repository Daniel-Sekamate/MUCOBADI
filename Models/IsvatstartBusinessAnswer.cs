using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class IsvatstartBusinessAnswer
    {
        public int IsvatstartBusinessAnswerId { get; set; }
        public int? IsvatheaderId { get; set; }
        public int? StartBusinessQuestionId { get; set; }
        public string StartBusinessQuestionAnswer { get; set; }

        public virtual Isvatheader Isvatheader { get; set; }
        public virtual AStartBusinessQuestion StartBusinessQuestion { get; set; }
    }
}
