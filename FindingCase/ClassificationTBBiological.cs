using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NtpManagement.Models.FindingCase
{
    public class ClassificationTBBiological
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(1)]
        public string ClassificationTBBiologicalId { get; set; }

        [Display(Name = "Classification Biological")]
        [Required]
        [MaxLength(45)]
        public string Label { get; set; }

        [Display(Name = "Description")]
        [MaxLength(300)]
        public string Description { get; set; }


        public bool Pulmonary { get; set; }

        public ClassificationTBBiological()
        {
            Pulmonary = true;
        }

    }
}
