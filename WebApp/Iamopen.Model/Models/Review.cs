using System;
using System.ComponentModel.DataAnnotations;
using IAmOpen.Model.Models.Base;

namespace IAmOpen.Model.Models
{
    public class Review : EntityWithID<int>
    {
        [Required(ErrorMessage = "Review body is required!")]
        public string Text { get; set; }

        [Display(Name = "Review Date")]
        public DateTime DateOfReport { get; set; }

        [Display(Name = "Author")]
        public int? UserID { get; set; }

        public virtual User Author { get; set; }

        [Display(Name = "Review about")]
        public int? InstitutionID { get; set; }

        public virtual Institution ReferredInstitution { get; set; }

        [Display(Name = "Chain")]
        public int? ChainID { get; set; }

        public virtual Chain ReferredChain { get; set; }
    }
}