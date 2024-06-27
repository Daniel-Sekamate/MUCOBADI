using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuAttendenceFormDetail
    {
        public int AttendenceFormDetailId { get; set; }
        public double? SerialNumber { get; set; }
        public int? ClientAttendenceId { get; set; }
        public string ClientPhoneContact { get; set; }
        public string ClientCode { get; set; }
        public DateTime? SessionOneDate { get; set; }
        public DateTime? SessionTwoDate { get; set; }
        public DateTime? SessionThreeDate { get; set; }
        public DateTime? SessionFourDate { get; set; }
        public DateTime? SessionFiveDate { get; set; }
        public DateTime? SessionSixDate { get; set; }
        public int? KaguguIdSessionOne { get; set; }
        public int? AttendedIdSessionOne { get; set; }
        public int? ReasonSessionOne { get; set; }
        public int AttendenceFormHeaderId { get; set; }
        public int? KaguguIdSessionTwo { get; set; }
        public int? AttendedIdSessionTwo { get; set; }
        public int? ReasonSessionTwo { get; set; }
        public int? KaguguIdSessionThree { get; set; }
        public int? AttendedIdSessionThree { get; set; }
        public int? ReasonSessionThree { get; set; }
        public int? KaguguIdSessionFour { get; set; }
        public int? AttendedIdSessionFour { get; set; }
        public int? ReasonSessionFour { get; set; }
        public int? KaguguIdSessionFive { get; set; }
        public int? AttendedIdSessionFive { get; set; }
        public int? ReasonSessionFive { get; set; }
        public int? KaguguIdSessionSix { get; set; }
        public int? AttendedIdSessionSix { get; set; }
        public int? ReasonSessionSix { get; set; }
        public string OtherReasoneSessionOne { get; set; }
        public string OtherReasoneSessionTwo { get; set; }
        public string OtherReasoneSessionThree { get; set; }
        public string OtherReasoneSessionFour { get; set; }
        public string OtherReasoneSessionFive { get; set; }
        public string OtherReasoneSessionSix { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual SmuAttendanceKey AttendedIdSessionFiveNavigation { get; set; }
        public virtual SmuAttendanceKey AttendedIdSessionFourNavigation { get; set; }
        public virtual SmuAttendanceKey AttendedIdSessionOneNavigation { get; set; }
        public virtual SmuAttendanceKey AttendedIdSessionSixNavigation { get; set; }
        public virtual SmuAttendanceKey AttendedIdSessionThreeNavigation { get; set; }
        public virtual SmuAttendanceKey AttendedIdSessionTwoNavigation { get; set; }
        public virtual SmuAttendenceHeader AttendenceFormHeader { get; set; }
        public virtual SmuKaguguScore KaguguIdSessionFiveNavigation { get; set; }
        public virtual SmuKaguguScore KaguguIdSessionFourNavigation { get; set; }
        public virtual SmuKaguguScore KaguguIdSessionOneNavigation { get; set; }
        public virtual SmuKaguguScore KaguguIdSessionSixNavigation { get; set; }
        public virtual SmuKaguguScore KaguguIdSessionThreeNavigation { get; set; }
        public virtual SmuKaguguScore KaguguIdSessionTwoNavigation { get; set; }
        public virtual SmuReasonsForSessionAbsence ReasonSessionFiveNavigation { get; set; }
        public virtual SmuReasonsForSessionAbsence ReasonSessionFourNavigation { get; set; }
        public virtual SmuReasonsForSessionAbsence ReasonSessionOneNavigation { get; set; }
        public virtual SmuReasonsForSessionAbsence ReasonSessionSixNavigation { get; set; }
        public virtual SmuReasonsForSessionAbsence ReasonSessionThreeNavigation { get; set; }
        public virtual SmuReasonsForSessionAbsence ReasonSessionTwoNavigation { get; set; }
    }
}
