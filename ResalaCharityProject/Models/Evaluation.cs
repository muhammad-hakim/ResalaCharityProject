using ResalaCharityProject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResalaCharityProject.Models
{
    public class Evaluation
    {
        public int Id { get; set; }
     
        public int FamilyId { get; set; }

        public string OldEvaluation { get; set; }
        
        public string NewEvaluation { get; set; }

        public string ReEvaluationReason { get; set; }

        public DateTime ReEvaluationDate { get; set; }

        public ResearchStatus Status { get; set; }

        public string Notes { get; set; }
    }
}
