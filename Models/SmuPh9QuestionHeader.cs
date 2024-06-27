using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuPh9QuestionHeader
    {
        public SmuPh9QuestionHeader()
        {
            SmuTerminantionGuidePh9Questions = new HashSet<SmuTerminantionGuidePh9Questions>();
        }

        public int Ph9QuestionHeaderId { get; set; }
        public string Ph9QuestionDescription { get; set; }
        public double? Ph9QuestionScore { get; set; }
        public bool? Ph9QuestionDescriptionIsVisible { get; set; }

        public virtual ICollection<SmuTerminantionGuidePh9Questions> SmuTerminantionGuidePh9Questions { get; set; }
    }
}
