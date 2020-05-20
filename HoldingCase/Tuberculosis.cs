
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NtpManagement.Models.HoldingCase
{
    public class Tuberculosis
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TuberculosisId { get; set; }

        [Display(Name = "Extrapulmonary (EPTB)")]
        public bool EPTB { get; set; }

        [Display(Name = "Pulmonary (PTB)")]
        public bool PTB { get; set; }

        [Display(Name = "Disease TB)")]
        public bool DiseaseTB { get; set; }

        [Display(Name = "Infectious TB)")]
        public bool InfectiousTB { get; set; }

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


        public int FKPresumptiveTB { get; set; }
        public PresumptiveTB PresumptiveTB { get; set; }
    }
}
