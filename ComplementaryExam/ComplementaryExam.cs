using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NtpManagement.Models.ComplementaryExam
{
    public class ComplementaryExam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(8)]
        [Display(Name ="Code")]
        public string ComplementaryExamId { get; set; }


        public bool Prescrit { get; set; }

        [MaxLength(200)]
        [Display(Name = "Label")]
        public string Label { get; set; }

        [MaxLength(45)]
        [Display(Name = "Short label")]
        public string ShortLabel { get; set; }


        [Display(Name = "Result")]
        [MaxLength(300)]
        public string Result { get; set; }

        //public Dictionary<string , string > Resultat { get; set; }

        public string KindComplementaryExamId { get; set; }

       
    }
}
