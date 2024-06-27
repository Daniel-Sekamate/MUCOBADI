using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AMaritalStatus
    {
        public AMaritalStatus()
        {
            Avat = new HashSet<Avat>();
            Hvat = new HashSet<Hvat>();
        }

        public int MaritalStatusId { get; set; }
        public string MaritalStatusDescription { get; set; }

        public virtual ICollection<Avat> Avat { get; set; }
        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
