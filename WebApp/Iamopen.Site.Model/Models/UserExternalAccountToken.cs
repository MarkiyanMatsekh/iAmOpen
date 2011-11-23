using System.ComponentModel.DataAnnotations;
using IAmOpen.Site.Model.Models.Base;

namespace IAmOpen.Site.Model.Models
{
    public class UserExternalAccountToken : EntityWithID<int>
    {
        [Display(Name = "User")]
        public int UserID { get; set; }

        public virtual User User { get; set; }

        [Display(Name = "External Account")]
        public int ExternalAccountID { get; set; }

        public virtual ExternalAccount Account { get; set; }

        [Display(Name = "Security Token")]
        // what the hell is this? :D
            public int SecurityToken { get; set; }

    }
}