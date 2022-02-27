using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResalaCharityProject.Models
{
    public class ModelBase
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int CreatedBy { get; set; }
        
        [Required]
        public DateTime CreatedOn { get; set; }
        
        public int? ModifieddBy { get; set; }
        
        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; } = false;

        public bool IsActive { get; set; } = true;
        
        public string Notes { get; set; }
    }
}
