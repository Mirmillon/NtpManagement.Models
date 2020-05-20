using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NtpManagement.Models.FindingCase
{
    public class ClassificationTBDrug
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(1)]
        public string ClassificationTBDrugId { get; set; }

        [Display(Name = "Classification Drug")]
        [Required]
        [MaxLength(45)]
        public string Label { get; set; }

        [Display(Name = "Description")]
        [MaxLength(300)]
        public string Description { get; set; }
    }
}
