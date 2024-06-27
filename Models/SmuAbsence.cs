using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuAbsence
    {
        public SmuAbsence()
        {
            SmuAttendenceFormDetailAttendedIdSessionFiveNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailAttendedIdSessionFourNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailAttendedIdSessionOneNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailAttendedIdSessionThreeNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailAttendedIdSessionTwoNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailKaguguIdSessionSixNavigation = new HashSet<SmuAttendenceFormDetail>();
        }

        public int AbsenceId { get; set; }
        public string AbsenceDescription { get; set; }

        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailAttendedIdSessionFiveNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailAttendedIdSessionFourNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailAttendedIdSessionOneNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailAttendedIdSessionThreeNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailAttendedIdSessionTwoNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailKaguguIdSessionSixNavigation { get; set; }
    }
}
