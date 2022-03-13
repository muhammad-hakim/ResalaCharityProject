using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResalaCharityProject.Models
{
    public class FamilyProfile : FamilyBase
    {
        public string PaterfamiliasNationalId { get; set; }

        public int FamilyMembersCount { get; set; }
        /// <summary>
        /// To be discussed with Resala
        /// </summary>
        public int FamilyMembersUnder16Count { get; set; }
        /// <summary>
        /// To be discussed with Resala
        /// </summary>
        public int FamilyMembersAbove50Count { get; set; }

        public string EvaluationDetails { get; set; }
        
        public Region Region { get; set; }
        public Evaluation LastEvaluation => EvaluationHistory?.Single(e => !e.IsDeleted && e.Id == EvaluationHistory.Max(e=>e.Id));
        public IEnumerable<DisabledChild> DisabledChildren { get; set; }

        public IEnumerable<OrphanChild> OrphanChildren { get; set; }

        public ICollection<FamilyContribution> DeservedContributions { get; set; }

        public ICollection<Evaluation> EvaluationHistory { get; set; }

        public ICollection<FamilyReceivedContribution> FamilyReceivedContributions { get; set; }

    }
}
