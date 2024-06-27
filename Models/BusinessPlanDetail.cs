using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class BusinessPlanDetail
    {
        public int BusinessPlanDetailId { get; set; }
        public int? BusinessPlanHeaderId { get; set; }
        public int? BusinessPlanQuestionId { get; set; }
        public string BusinessPlanAnswer { get; set; }

        public virtual BusinessPlanHeader BusinessPlanHeader { get; set; }
        public virtual ABusinessPlanQuestion BusinessPlanQuestion { get; set; }
    }
}
