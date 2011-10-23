using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace IAmOpen.Model.Models
{
    public class Role
    {
        public int RoleID { get; set; }

        [Required(ErrorMessage = "Role Name is required!")]
        [MaxLength(50,ErrorMessage = "Role Name cannot be longer than 50 characters!")]
        [Display(Name = "Role")]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
