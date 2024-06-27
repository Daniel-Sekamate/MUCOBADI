using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class IsvatcurrentBusinessRisk
    {
        public int IsvatcurrentBusinessRiskId { get; set; }
        public int? IsvatheaderId { get; set; }
        public int? CurrenBusinessRiskId { get; set; }
        public string OtherCurrenBusinessRisk { get; set; }
        public int? RiskLevelRatingId { get; set; }

        public virtual ACurrenBusinessRisk CurrenBusinessRisk { get; set; }
        public virtual Isvatheader Isvatheader { get; set; }
        public virtual ARiskLevelRating RiskLevelRating { get; set; }
    }
}
