using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ANmnSectionTwoQuestion
    {
        public ANmnSectionTwoQuestion()
        {
            ANmnSectionTwoAnswer = new HashSet<ANmnSectionTwoAnswer>();
            NmnquestionaireSectionTwo = new HashSet<NmnquestionaireSectionTwo>();
        }

        public int QuestionId { get; set; }
        public string QuestionDesc { get; set; }

        public virtual ICollection<ANmnSectionTwoAnswer> ANmnSectionTwoAnswer { get; set; }
        public virtual ICollection<NmnquestionaireSectionTwo> NmnquestionaireSectionTwo { get; set; }
    }
}
