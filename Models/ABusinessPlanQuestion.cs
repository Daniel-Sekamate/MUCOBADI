using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ABusinessPlanQuestion
    {
        public ABusinessPlanQuestion()
        {
            BusinessPlanDetail = new HashSet<BusinessPlanDetail>();
        }

        public int BusinessPlanQuestionId { get; set; }
        public string QuestionCategory { get; set; }
        public string QuestionClassification { get; set; }
        public string Question { get; set; }

        public virtual ICollection<BusinessPlanDetail> BusinessPlanDetail { get; set; }
    }
}
