using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NtpManagement.Models
{
    public class MedicalConsultation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MedicalConsultationId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date appointement")]
        public DateTime DateAppointement { get; set; }

        [Display(Name = "Health Provider")]
        public int HealthProviderId { get; set; }

        [Display(Name = "Weight")]
        public double Weight { get; set; }

        public IEnumerable<PresumptiveTBComplementaryExam> ComplementaryExams { get; set; }

        public int PresumptiveTBId { get; set; }
        public PresumptiveTB PresumptiveTB { get; set; }

        [MaxLength(600)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Note")]
        public string  Note { get; set; }

        public MedicalConsultation()
        {
            DateAppointement = DateTime.Today;
        }

       
    }
}
