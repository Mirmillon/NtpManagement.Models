using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NtpManagement.Models.ComplementaryExam
{
    public class KindComplementaryExam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string KindComplementaryExamId { get; set; }

        [Display(Name ="Label")]
        [MaxLength(60)]
        public string Label { get; set; }

        
    }
}
