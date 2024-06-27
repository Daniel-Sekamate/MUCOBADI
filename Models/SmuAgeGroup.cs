using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuAgeGroup
    {
        public SmuAgeGroup()
        {
            SmuClientRegistrationForm = new HashSet<SmuClientRegistrationForm>();
        }

        public int AgeGroupId { get; set; }
        public string AgeGroup { get; set; }

        public virtual ICollection<SmuClientRegistrationForm> SmuClientRegistrationForm { get; set; }
    }
}
