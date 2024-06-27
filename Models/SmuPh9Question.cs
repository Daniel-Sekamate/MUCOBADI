using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuPh9Question
    {
        public SmuPh9Question()
        {
            SmuAssessmentGuidePh9Questions = new HashSet<SmuAssessmentGuidePh9Questions>();
            SmuTerminantionGuidePh9Questions = new HashSet<SmuTerminantionGuidePh9Questions>();
        }

        public int Ph9QuestionId { get; set; }
        public string Ph9Question { get; set; }
        public int? SmuFormId { get; set; }
        public bool? IsPh9QuestionVisible { get; set; }
        public string FormTypeId { get; set; }

        public virtual ICollection<SmuAssessmentGuidePh9Questions> SmuAssessmentGuidePh9Questions { get; set; }
        public virtual ICollection<SmuTerminantionGuidePh9Questions> SmuTerminantionGuidePh9Questions { get; set; }
    }
}
