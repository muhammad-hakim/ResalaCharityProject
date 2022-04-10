using ResalaCharityProject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResalaCharityProject.Models
{
    /// <summary>
    /// Pending research request 
    /// </summary>
    public class ResearchRequest : FamilyBase
    {
        public ResearchStatus Status { get; set; }
        
        public string RejectionReason { get; set; }
        
        public RequestSource Source { get; set; }

        public DateTime RequestDate { get; set; }

        public DateTime ResultDate { get; set; }
    }
}
