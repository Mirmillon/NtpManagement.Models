using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NtpManagement.Models.FindingCase
{
    public class State
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(1)]
        public string StateId { get; set; }

        [Display(Name = "State")]
        [Required]
        [MaxLength(20)]
        public string Label { get; set; }

    }
}
