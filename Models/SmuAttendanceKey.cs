using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuAttendanceKey
    {
        public SmuAttendanceKey()
        {
            SmuAttendenceFormDetailAttendedIdSessionFiveNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailAttendedIdSessionFourNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailAttendedIdSessionOneNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailAttendedIdSessionSixNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailAttendedIdSessionThreeNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailAttendedIdSessionTwoNavigation = new HashSet<SmuAttendenceFormDetail>();
        }

        public int AttendenceKeyId { get; set; }
        public string AttendenceKey { get; set; }

        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailAttendedIdSessionFiveNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailAttendedIdSessionFourNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailAttendedIdSessionOneNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailAttendedIdSessionSixNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailAttendedIdSessionThreeNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailAttendedIdSessionTwoNavigation { get; set; }
    }
}
