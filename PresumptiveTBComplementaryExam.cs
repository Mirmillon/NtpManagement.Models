using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NtpManagement.Models
{
    public class PresumptiveTBComplementaryExam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PresumptiveTBComplementaryExamId { get; set; }

        public string ComplementaryExamId { get; set; }

        [Display(Name = "Performed by")]
        public int PerformedHealthProviderId;


        [Display(Name = "Date Prescibed")]
        [DataType(DataType.Date)]
        public DateTime? DatePrescribed { get; set; }


        [Display(Name = "Date Received")]
        [DataType(DataType.Date)]
        public DateTime? DateReceived { get; set; }

        [Display(Name = "Date Performed")]
        [DataType(DataType.Date)]
        public DateTime? DatePerformed { get; set; }

        [Display(Name = "Released by")]
        public int? HealthProviderId;

        [Display(Name = "Date Released")]
        [DataType(DataType.Date)]
        public DateTime? DateReleased { get; set; }

        [Display(Name = "Result")]
        [DataType(DataType.MultilineText)]
        public string Result { get; set; }

        public int MedicalConsultationId { get; set; }
        public MedicalConsultation MedicalConsultation { get; set; }

       


    }
}
