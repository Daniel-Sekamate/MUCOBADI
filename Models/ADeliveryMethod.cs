using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ADeliveryMethod
    {
        public ADeliveryMethod()
        {
            InterventionAttendanceForm = new HashSet<InterventionAttendanceForm>();
            Nmnquestionaire = new HashSet<Nmnquestionaire>();
        }

        public int DeliveryMethodId { get; set; }
        public string DeliveryMethodDesc { get; set; }

        public virtual ICollection<InterventionAttendanceForm> InterventionAttendanceForm { get; set; }
        public virtual ICollection<Nmnquestionaire> Nmnquestionaire { get; set; }
    }
}
