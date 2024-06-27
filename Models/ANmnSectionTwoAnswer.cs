using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ANmnSectionTwoAnswer
    {
        public ANmnSectionTwoAnswer()
        {
            NmnquestionaireSectionTwo = new HashSet<NmnquestionaireSectionTwo>();
        }

        public int AnswerId { get; set; }
        public int? QuestionId { get; set; }
        public string AnswerDesc { get; set; }

        public virtual ANmnSectionTwoQuestion Question { get; set; }
        public virtual ICollection<NmnquestionaireSectionTwo> NmnquestionaireSectionTwo { get; set; }
    }
}
