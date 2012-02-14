using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IAmOpen.Site.Model.Models.Base;

namespace IAmOpen.Site.Model.Models
{
    public class Chain : EntityWithID<int>
    {
        [Required(ErrorMessage = "Chain Name is required!")]
        [MaxLength(50, ErrorMessage = "Chain Name cannot be longer than 50 characters")]
        public string Name { get; set; }

        [Display(Name = "Icon")]
        public string IconPath { get; set; }

        [Display(Name = "Status")]
        public int StatusID { get; set; }

        public virtual Status Status { get; set; }

        public virtual ICollection<Institution> Institutions { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}