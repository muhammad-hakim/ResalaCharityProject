using ResalaCharityProject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResalaCharityProject.Models
{
    public class FamilyBase : ModelBase
    {
        public string Code { get; set; }

        public string PaterfamiliasName { get; set; }

        public string Nationality { get; set; }

        public SocialStatus SocialStatus { get; set; }

        public string Mobile { get; set; }

        public string Address { get; set; }
    }
}
