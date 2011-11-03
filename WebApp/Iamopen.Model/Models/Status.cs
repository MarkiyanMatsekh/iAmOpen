using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IAmOpen.Model.Models.Base;

namespace IAmOpen.Model.Models
{
    public class Status : EquatableEntity
    {
        public int StatusID { get; set; }

        [Required(ErrorMessage = "Status Name is required!")]
        [MaxLength(50, ErrorMessage = "Status Name cannot be longer than 50 characters!")]
        [Display(Name = "Status")]
        public string Name { get; set; }

        public virtual ICollection<Institution> Institutions { get; set; }

        public virtual ICollection<Chain> Chains { get; set; }

        public override object EntityID
        {
            get { return StatusID; }
            set { StatusID = (int) value; }
        }
    }
}