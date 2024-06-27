using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ANmnSectionOneQuestion
    {
        public ANmnSectionOneQuestion()
        {
            NmnquestionaireSectionOne = new HashSet<NmnquestionaireSectionOne>();
        }

        public int QuestionId { get; set; }
        public string QuestionDesc { get; set; }

        public virtual ICollection<NmnquestionaireSectionOne> NmnquestionaireSectionOne { get; set; }
    }
}
