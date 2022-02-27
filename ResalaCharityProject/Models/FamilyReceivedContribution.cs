using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResalaCharityProject.Models
{
    public class FamilyReceivedContribution
    {
        public int FamilyId { get; set; }
        
        public int ContributionId { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string Notes { get; set; }
    }
}
