using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AStartBusinessQuestion
    {
        public AStartBusinessQuestion()
        {
            IsvatstartBusinessAnswer = new HashSet<IsvatstartBusinessAnswer>();
        }

        public int StartBusinessQuestionId { get; set; }
        public string StartBusinessQuestionDesc { get; set; }

        public virtual ICollection<IsvatstartBusinessAnswer> IsvatstartBusinessAnswer { get; set; }
    }
}
