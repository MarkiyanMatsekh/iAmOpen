using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace IAmOpen.Model.Models
{
    public class Vote
    {
        public int VoteID { get; set; }

        [Display(Name = "Institution")]
        public int? InstitutionID { get; set; }
        public virtual Institution Institution { get; set; }

        [Display(Name = "Chain")]
        public int? ChainID { get; set; }
        public virtual Chain Chain { get; set; }

        [Display(Name = "Voter")]
        public int UserID { get; set; }
        public virtual User Voter { get; set; }

        [Required(ErrorMessage = "Rating is required!")]
        [Display(Name = "Rating")]
        //add range for rating here. Need to ddecide range
        public short Value { get; set; }
    }
}
