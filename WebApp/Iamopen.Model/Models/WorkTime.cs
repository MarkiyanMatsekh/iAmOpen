#region


using System;
using System.ComponentModel.DataAnnotations;
using IAmOpen.Model.Models.Base;


#endregion


namespace IAmOpen.Model.Models
{
    public class WorkTime : EntityWithID<int>
    {
        [Required(ErrorMessage = "Institution is required!")]
        public int InstitutionID { get; set; }

        public virtual Institution Institution { get; set; }

        [Range(0, 6, ErrorMessage = "Day should be in range from 0 to 6!")]
        [Display(Name = "Day Of Week")]
        public int? DayOfWeekID { get; set; }

        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Opening Time is required!")]
        [Display(Name = "Opening Time")]
        public TimeSpan OpeningTime { get; set; }

        [Required(ErrorMessage = "Closing Time is required!")]
        [Display(Name = "Closing Time")]
        public TimeSpan ClosingTime { get; set; }
    }
}