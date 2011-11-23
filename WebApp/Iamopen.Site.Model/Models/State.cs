using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IAmOpen.Site.Model.Models.Base;

namespace IAmOpen.Site.Model.Models
{
    public class State : EntityWithID<int>
    {
        [Required(ErrorMessage = "State Name is required!")]
        [MaxLength(50, ErrorMessage = "State Name cannot be longer than 50 characters!")]
        public string Name { get; set; }

        public string Details { get; set; }

        public virtual ICollection<Institution> Institutions { get; set; }

    }
}