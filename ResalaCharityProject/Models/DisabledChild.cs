using ResalaCharityProject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResalaCharityProject.Models
{
    public class DisabledChild : ModelBase
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public DisabilityType DisabilityType { get; set; }
    }
}
