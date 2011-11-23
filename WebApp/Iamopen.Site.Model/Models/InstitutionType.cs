using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IAmOpen.Site.Model.Models.Base;

namespace IAmOpen.Site.Model.Models
{
    public class InstitutionType : EntityWithID<int>
    {
        [Required(ErrorMessage = "Type Name is required!")]
        [MaxLength(50, ErrorMessage = "Institution type name cannot be longer than 50 characters!")]
        public string Name { get; set; }

        [Display(Name = "Icon")]
        public string IconPath { get; set; }

        public virtual ICollection<Institution> Institutions { get; set; }

    }
}