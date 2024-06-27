using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class GraduationChecklistDetail
    {
        public int GraduationChecklistDetailId { get; set; }
        public int GraduationChecklistId { get; set; }
        public int GraduationCriteriaId { get; set; }
        public int ResponseYesNoId { get; set; }

        public virtual GraduationChecklistHeader GraduationChecklist { get; set; }
        public virtual AGraduationCriteria GraduationCriteria { get; set; }
        public virtual AYesNo ResponseYesNo { get; set; }
    }
}
