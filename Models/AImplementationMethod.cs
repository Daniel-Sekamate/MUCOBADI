using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AImplementationMethod
    {
        public AImplementationMethod()
        {
            Nmnquestionaire = new HashSet<Nmnquestionaire>();
        }

        public int ImplementationMethodId { get; set; }
        public string ImplementationMethodDesc { get; set; }

        public virtual ICollection<Nmnquestionaire> Nmnquestionaire { get; set; }
    }
}
