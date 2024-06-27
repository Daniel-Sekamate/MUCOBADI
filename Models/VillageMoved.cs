using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class VillageMoved
    {
        public int VillageId { get; set; }
        public int? ParishId { get; set; }
        public string VillageDescription { get; set; }
    }
}
