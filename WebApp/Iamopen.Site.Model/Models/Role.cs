using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IAmOpen.Model.Models.Base;

namespace IAmOpen.Model.Models
{
    public class Role : EntityWithID<int>
    {
        [Required(ErrorMessage = "Role Name is required!")]
        [MaxLength(50, ErrorMessage = "Role Name cannot be longer than 50 characters!")]
        [Display(Name = "Role")]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }

    }
}