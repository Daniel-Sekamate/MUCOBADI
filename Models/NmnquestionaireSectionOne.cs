using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class NmnquestionaireSectionOne
    {
        public int NmnsectionOneId { get; set; }
        public int? Nmnid { get; set; }
        public int? QuestionId { get; set; }
        public int? AgreeDisagreeId { get; set; }

        public virtual AAgreeDisagree AgreeDisagree { get; set; }
        public virtual Nmnquestionaire Nmn { get; set; }
        public virtual ANmnSectionOneQuestion Question { get; set; }
    }
}
