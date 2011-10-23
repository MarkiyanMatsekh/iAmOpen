using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace IAmOpen.Model.Models
{
    public class State
    {
        public int StateID { get; set; }

        [Required(ErrorMessage = "State Name is required!")]
        [MaxLength(50,ErrorMessage = "State Name cannot be longer than 50 characters!")]
        public string Name { get; set; }

        public string Details { get; set; }

        public virtual ICollection<Institution> Institutions { get; set; }
    }
}
