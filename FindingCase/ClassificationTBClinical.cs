using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NtpManagement.Models.FindingCase
{
    public class ClassificationTBClinical
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(1)]
        public string ClassificationTBClinicalId { get; set; }

        [Display(Name = "Classification Clinical")]
        [Required]
        [MaxLength(45)]
        public string Label { get; set; }

        [Display(Name = "Description")]
        [MaxLength(600)]
        public string Description { get; set; }

        public bool Pulmonary { get; set; }

        public ClassificationTBClinical()
        {
            Pulmonary = true;
        }
    }
}
