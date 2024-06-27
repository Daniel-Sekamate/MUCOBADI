using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuTerminantionGuidePh9Questions
    {
        public int SmuTerminantionGuidePh9QuestionsId { get; set; }
        public int? SmuTerminantionGuideId { get; set; }
        public double? SmuTerminantionGuidePh9QuestionsSored { get; set; }
        public int? Ph9QuestionsId { get; set; }
        public int? Ph9QuestionHeaderId { get; set; }
        public int? SerialNumber { get; set; }

        public virtual SmuPh9QuestionHeader Ph9QuestionHeader { get; set; }
        public virtual SmuPh9Question Ph9Questions { get; set; }
        public virtual SmuTerminantionGuide SmuTerminantionGuide { get; set; }
    }
}
