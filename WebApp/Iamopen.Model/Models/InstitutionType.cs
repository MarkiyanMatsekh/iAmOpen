using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IAmOpen.Model.Models
{
    public class InstitutionType
    {
        public int InstitutionTypeID { get; set; }

        [Required(ErrorMessage = "Type Name is required!")]
        [MaxLength(50,ErrorMessage="Institution type name cannot be longer than 50 characters!")]
        public string Name { get; set; }

        [Display(Name = "Icon")]
        public string IconPath { get; set; }

        public virtual ICollection<Institution> Institutions { get; set; }
    }
}