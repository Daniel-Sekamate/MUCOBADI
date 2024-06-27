using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class NmnquestionaireSectionTwo
    {
        public int NmnsectionTwoId { get; set; }
        public int? Nmnid { get; set; }
        public int? QuestionId { get; set; }
        public int? AnswerId { get; set; }

        public virtual ANmnSectionTwoAnswer Answer { get; set; }
        public virtual Nmnquestionaire Nmn { get; set; }
        public virtual ANmnSectionTwoQuestion Question { get; set; }
    }
}
