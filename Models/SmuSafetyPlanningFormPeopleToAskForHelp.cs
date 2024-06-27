using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuSafetyPlanningFormPeopleToAskForHelp
    {
        public int PeopleToAskForHelpId { get; set; }
        public string PeopleToAskForHelpName { get; set; }
        public string PeopleToAskForHelpPhone { get; set; }
        public int? SafetyPlanningFormId { get; set; }
        public string PeopleToAskForHelpNo { get; set; }

        public virtual SmuSafetyPlanningForm SafetyPlanningForm { get; set; }
    }
}
