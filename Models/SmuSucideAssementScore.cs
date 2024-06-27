using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuSucideAssementScore
    {
        public int SucideAssementScoreId { get; set; }
        public double? SucideAssementScore { get; set; }
        public int? SucideAssementQuestionId { get; set; }
        public int? SucideAssementResponseId { get; set; }

        public virtual SmuSucideAssementQuestion SucideAssementQuestion { get; set; }
    }
}
