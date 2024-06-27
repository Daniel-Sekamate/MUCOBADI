using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuProgram
    {
        public SmuProgram()
        {
            SmuAssessmentGuide = new HashSet<SmuAssessmentGuide>();
        }

        public int SmuProgramId { get; set; }
        public string SmuProgramDescription { get; set; }

        public virtual ICollection<SmuAssessmentGuide> SmuAssessmentGuide { get; set; }
    }
}
