using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IAmOpen.Model.Models.Base;

namespace IAmOpen.Model.Models
{
    public class State : EquatableEntity
    {
        public int StateID { get; set; }

        [Required(ErrorMessage = "State Name is required!")]
        [MaxLength(50, ErrorMessage = "State Name cannot be longer than 50 characters!")]
        public string Name { get; set; }

        public string Details { get; set; }

        public virtual ICollection<Institution> Institutions { get; set; }

        public override object EntityID
        {
            get { return StateID; }
            set { StateID = (int) value; }
        }
    }
}