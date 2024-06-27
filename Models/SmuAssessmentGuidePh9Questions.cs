using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuAssessmentGuidePh9Questions
    {
        public int SmuAssessmentGuidePh9QuestionsId { get; set; }
        public int? SmuAssessmentGuideId { get; set; }
        public double? SmuAssessmentGuidePh9QuestionsSored { get; set; }
        public int? Ph9QuestionsId { get; set; }
        public int? Ph9QuestionHeaderId { get; set; }
        public int? SerialNumber { get; set; }

        public virtual SmuPh9Question Ph9Questions { get; set; }
        public virtual SmuAssessmentGuide SmuAssessmentGuide { get; set; }
    }
}
