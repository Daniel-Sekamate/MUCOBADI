using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AAgreeDisagree
    {
        public AAgreeDisagree()
        {
            NmnquestionaireSectionOne = new HashSet<NmnquestionaireSectionOne>();
        }

        public int AgreeDisagreeId { get; set; }
        public string AgreeDisagreeDesc { get; set; }

        public virtual ICollection<NmnquestionaireSectionOne> NmnquestionaireSectionOne { get; set; }
    }
}
