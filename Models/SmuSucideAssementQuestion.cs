using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuSucideAssementQuestion
    {
        public SmuSucideAssementQuestion()
        {
            SmuSucideAssementFormHeader = new HashSet<SmuSucideAssementFormHeader>();
            SmuSucideAssementScore = new HashSet<SmuSucideAssementScore>();
        }

        public int SucideAssementQuestionId { get; set; }
        public string SucideAssementQuestion { get; set; }

        public virtual ICollection<SmuSucideAssementFormHeader> SmuSucideAssementFormHeader { get; set; }
        public virtual ICollection<SmuSucideAssementScore> SmuSucideAssementScore { get; set; }
    }
}
