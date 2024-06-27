using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ABusinessVentureCapitalInvestment
    {
        public ABusinessVentureCapitalInvestment()
        {
            IsvatgeneratedProfit = new HashSet<IsvatgeneratedProfit>();
            Isvatloss = new HashSet<Isvatloss>();
            IsvatworkingCapital = new HashSet<IsvatworkingCapital>();
        }

        public int BusinessVentureCapitalInvestmentId { get; set; }
        public string BusinessVentureCapitalInvestmentDesc { get; set; }

        public virtual ICollection<IsvatgeneratedProfit> IsvatgeneratedProfit { get; set; }
        public virtual ICollection<Isvatloss> Isvatloss { get; set; }
        public virtual ICollection<IsvatworkingCapital> IsvatworkingCapital { get; set; }
    }
}
