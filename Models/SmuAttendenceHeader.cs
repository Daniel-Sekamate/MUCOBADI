using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuAttendenceHeader
    {
        public SmuAttendenceHeader()
        {
            SmuAttendenceFormDetail = new HashSet<SmuAttendenceFormDetail>();
        }

        public int AttendenceFormHeaderId { get; set; }
        public int? SmuGroupId { get; set; }
        public int? AttendenceYearId { get; set; }
        public int? AttendenceCycleId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CapturedBy { get; set; }
        public DateTime? SessionOneDate { get; set; }
        public DateTime? SessionTwoDate { get; set; }
        public DateTime? SessionThreeDate { get; set; }
        public DateTime? SessionFourDate { get; set; }
        public DateTime? SessionFiveDate { get; set; }
        public DateTime? SessionSixDate { get; set; }

        public virtual SmuCycle AttendenceCycle { get; set; }
        public virtual AFinancialYear AttendenceYear { get; set; }
        public virtual SmuGroup SmuGroup { get; set; }
        public virtual ICollection<SmuAttendenceFormDetail> SmuAttendenceFormDetail { get; set; }
    }
}
