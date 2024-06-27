using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class GraduationChecklistHeader
    {
        public GraduationChecklistHeader()
        {
            GraduationChecklistDetail = new HashSet<GraduationChecklistDetail>();
        }

        public int GraduationChecklistId { get; set; }
        public int? HouseHoldId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public string AssessorName { get; set; }
        public string AssessorTitle { get; set; }
        public string AssessorTel { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewerTitle { get; set; }
        public DateTime? ReviewDate { get; set; }

        public virtual BeneficiaryIdentificationRegister HouseHold { get; set; }
        public virtual HouseHoldMembers HouseHoldMember { get; set; }
        public virtual ICollection<GraduationChecklistDetail> GraduationChecklistDetail { get; set; }
    }
}
