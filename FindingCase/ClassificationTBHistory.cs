using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NtpManagement.Models.FindingCase
{
    public class ClassificationTBHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(1)]
        public string ClassificationTBHistoryId { get; set; }

        [Display(Name = "Classification History")]
        [Required]
        [MaxLength(30)]
        public string Label { get; set; }

        [Display(Name = "Description")]
        [MaxLength(300)]
        public string Description { get; set; }
    }
}
