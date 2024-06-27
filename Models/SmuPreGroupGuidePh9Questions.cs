using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuPreGroupGuidePh9Questions
    {
        public int SmuPreGroupGuidePh9QuestionsId { get; set; }
        public int? SmuPreGroupGuideId { get; set; }
        public double? SmuPreGroupGuidePh9QuestionsSored { get; set; }
        public int? Ph9QuestionsId { get; set; }
        public int? Ph9QuestionHeaderId { get; set; }
        public int? SerialNumber { get; set; }

        public virtual SmuPreGroupGuide SmuPreGroupGuide { get; set; }
    }
}
