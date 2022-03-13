using ResalaCharityProject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResalaCharityProject.Models
{
    /// <summary>
    /// With first evaluation, to insert FamilyProfile and Contributions(s)
    /// </summary>
    public class Evaluation : ModelBase
    {
        public int FamilyId { get; set; }

        public string OldEvaluationDescription { get; set; }
        
        public string NewEvaluationDescription { get; set; }

        public string ReEvaluationReason { get; set; }

        public DateTime ReEvaluationDate { get; set; }

        public ResearchStatus Status { get; set; }

    }
}
