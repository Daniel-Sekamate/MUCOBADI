using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuReasonsForSessionAbsence
    {
        public SmuReasonsForSessionAbsence()
        {
            SmuAttendenceFormDetailReasonSessionFiveNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailReasonSessionFourNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailReasonSessionOneNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailReasonSessionSixNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailReasonSessionThreeNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailReasonSessionTwoNavigation = new HashSet<SmuAttendenceFormDetail>();
        }

        public int ReasonForAbsenceId { get; set; }
        public string ReasonForAbsenceDescription { get; set; }

        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailReasonSessionFiveNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailReasonSessionFourNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailReasonSessionOneNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailReasonSessionSixNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailReasonSessionThreeNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailReasonSessionTwoNavigation { get; set; }
    }
}
