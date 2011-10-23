using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace IAmOpen.Model.Models
{
    public class Status
    {
        public int StatusID { get; set; }
        
        [Required(ErrorMessage = "Status Name is required!")]
        [MaxLength(50,ErrorMessage = "Status Name cannot be longer than 50 characters!")]
        [Display(Name = "Status")]
        public string Name { get; set; }

        public virtual ICollection<Institution> Institutions { get; set; }

        public virtual ICollection<Chain> Chains { get; set; }
    }
}
