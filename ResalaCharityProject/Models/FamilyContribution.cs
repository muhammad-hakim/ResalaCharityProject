using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ResalaCharityProject.Models
{
    /// <summary>
    /// To confirm from Resala if Assigned Contributions history is required
    /// </summary>
    public class FamilyContribution : ModelBase
    {
        //public int FamilyId { get; set; }

        //[ForeignKey("FamilyId")]
        //public FamilyProfile Family { get; set; }
        public int EvaluationId { get; set; }
        public Evaluation Evaluation { get; set; }

        public int ContribtionId { get; set; }

        public Contribution Contribution { get; set; }

        public DateTime ExpiryDate { get; set; }
    }
}
