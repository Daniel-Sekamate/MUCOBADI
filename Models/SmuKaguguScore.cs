using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuKaguguScore
    {
        public SmuKaguguScore()
        {
            SmuAttendenceFormDetailKaguguIdSessionFiveNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailKaguguIdSessionFourNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailKaguguIdSessionOneNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailKaguguIdSessionSixNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailKaguguIdSessionThreeNavigation = new HashSet<SmuAttendenceFormDetail>();
            SmuAttendenceFormDetailKaguguIdSessionTwoNavigation = new HashSet<SmuAttendenceFormDetail>();
        }

        public int KaguguScoreId { get; set; }
        public string KaguguScore { get; set; }

        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailKaguguIdSessionFiveNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailKaguguIdSessionFourNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailKaguguIdSessionOneNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailKaguguIdSessionSixNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailKaguguIdSessionThreeNavigation { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetailKaguguIdSessionTwoNavigation { get; set; }
    }
}
