using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SmuLevelOfDifficultyToCheckOffProblems
    {
        public SmuLevelOfDifficultyToCheckOffProblems()
        {
            SmuTerminantionGuide = new HashSet<SmuTerminantionGuide>();
        }

        public int LevelOfDifficultyId { get; set; }
        public string LevelOfDifficulty { get; set; }

        public virtual ICollection<SmuTerminantionGuide> SmuTerminantionGuide { get; set; }
    }
}
