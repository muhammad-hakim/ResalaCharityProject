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

        public int FamilyMembersUnder16Count { get; set; }

        public int FamilyMembersAbove50Count { get; set; }

        public string EvaluationDetails { get; set; }
        
        public Region Region { get; set; }

        public IEnumerable<DisabledChild> DisabledChildren { get; set; }

        public IEnumerable<OrphanChild> OrphanChildren { get; set; }

        public ICollection<FamilyContribution> Contributions { get; set; }

        public ICollection<Evaluation> EvaluationHistory { get; set; }

        public ICollection<FamilyReceivedContribution> FamilyReceivedContributions { get; set; }

    }
}
