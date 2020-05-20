
using NtpManagement.Models.HoldingCase;
using PeopleMedicalManagement.Models.Sick;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NtpManagement.Models
{
    public class PresumptiveTB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PresumptiveTBId { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date first appointement")]
        public DateTime DateFirst { get; set; }

        [Display(Name = "Walk In")]
        public bool PassiveFinding { get; set; }

        [Display(Name = "Referred")]
        public int  ReferredId { get; set; }

        [Display(Name = "Contact with TB Case ?")]
        public bool ContactTbCase { get; set; }

        [Display(Name = "High risk clinical groups ?")]
        public bool HighRiskClinical { get; set; }

        [Display(Name = "High risk population ?")]
        public bool HighRiskPopulation { get; set; }

        [Display(Name = "IHV Case ?")]
        public bool IHV { get; set; }

        [Display(Name = "Tuberculosis confirmed")]
        public bool TuberculosisConfirmed { get; set; }


        [Display(Name = "State")]//New
        public string  StateId { get; set; }

        [Display(Name = "Extrapulmonary (EPTB)")]
        public bool EPTB { get; set; }

        [Display(Name = "Pulmonary (PTB)")]//New
        public bool PTB { get; set; }

        [Display(Name = "Disease TB)")]
        public bool DiseaseTB { get; set; }

        [Display(Name = "Infectious TB)")]//New
        public bool InectiousTB { get; set; }

        [MaxLength(1)]
        [Display(Name = "Clinical Classification ")]
        public string ClassificationTBClinicalId { get; set; }


        [MaxLength(1)]
        [Display(Name = "Biological Classification")]
        public string ClassificationTBBiologicalId { get; set; }

        [MaxLength(1)]
        [Display(Name = "Drug Classification ")]
        public string ClassificationTBDrugId { get; set; }

        [MaxLength(1)]
        [Display(Name = "History Classification ")]
        public string ClassificationTBHistoryId { get; set; }


        [MaxLength(600)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Note")]
        public string Note { get; set; }

        public IEnumerable<PresumptiveTBMate> PatientMates { get; set; }

        public IEnumerable<MedicalConsultation> MedicalConsultations { get; set; }



     

        public PresumptiveTB()
        {
            DateFirst = DateTime.Today;
         
        }

        public Tuberculosis Tuberculosis { get; set; }



    }
}
