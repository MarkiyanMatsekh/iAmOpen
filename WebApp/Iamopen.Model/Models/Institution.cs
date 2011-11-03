using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IAmOpen.Model.Models.Base;

namespace IAmOpen.Model.Models
{
    public class Institution : EquatableEntity
    {
        public int InstitutionID { get; set; }

        [Display(Name = "Icon")]
        public string IconPath { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime CreatedDLC { get; set; }

        [Required(ErrorMessage = "Coordinate X is required!")]
        public double CoordinatesX { get; set; }

        [Required(ErrorMessage = "Coordinate Y is required!")]
        public double CoordinatesY { get; set; }

        [Display(Name = "Creator")]
        public int UserID { get; set; }

        public virtual User CreatedByUser { get; set; }

        [Display(Name = "Status")]
        public int StatusID { get; set; }

        public virtual Status Status { get; set; }

        [Display(Name = "State")]
        public int StateID { get; set; }

        public virtual State State { get; set; }

        public double Rating { get; set; }

        public virtual ICollection<InstitutionType> Types { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<WorkTime> WorkHours { get; set; }

        public virtual ICollection<User> Visiters { get; set; }

        [Display(Name = "Belongs to chain")]
        public int? ChainID { get; set; }

        public virtual Chain Chain { get; set; }

        public override object EntityID
        {
            get { return InstitutionID; }
            set { InstitutionID = (int) value; }
        }
    }
}