using System;
using System.ComponentModel.DataAnnotations;


namespace NtpManagement.Models
{
    public class PresumptiveTBMate 
    {

        public int PresumptiveTBId { get; set; }
        public PresumptiveTB PresumptiveTB { get; set; }

        [Display(Name = "Checking")]
        public bool Checked { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Date Checking")]
        public DateTime CheckedDate { get; set; }

        [Display(Name = "How old ?")]
        public int Age { get; set; }

       



      

    }
}
