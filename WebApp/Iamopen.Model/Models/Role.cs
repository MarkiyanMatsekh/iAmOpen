using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IAmOpen.Model.Models.Base;

namespace IAmOpen.Model.Models
{
    public class Role : EquatableEntity
    {
        public int RoleID { get; set; }

        [Required(ErrorMessage = "Role Name is required!")]
        [MaxLength(50, ErrorMessage = "Role Name cannot be longer than 50 characters!")]
        [Display(Name = "Role")]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public override object EntityID
        {
            get { return RoleID; }
            set { RoleID = (int) value; }
        }
    }
}