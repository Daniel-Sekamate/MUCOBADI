using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuSucideAssementResponse
    {
        public SmuSucideAssementResponse()
        {
            SmuSucideAssementFormHeader = new HashSet<SmuSucideAssementFormHeader>();
        }

        public int SucideAssementResponseId { get; set; }
        public string SucideAssementResponse { get; set; }

        public virtual ICollection<SmuSucideAssementFormHeader> SmuSucideAssementFormHeader { get; set; }
    }
}
