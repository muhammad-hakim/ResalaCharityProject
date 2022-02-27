using ResalaCharityProject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResalaCharityProject.Models
{
    public class Contribution : ModelBase
    {
        public string Title { get; set; }

        public ContributionType Type { get; set; }

        public RecurrenceType Recurrence { get; set; }
    }
}
