using System.ComponentModel.DataAnnotations;
using IAmOpen.Model.Models.Base;

namespace IAmOpen.Model.Models
{
    public class UserExternalAccountToken : EquatableEntity
    {
        public int UserExternalAccountTokenID { get; set; }

        [Display(Name = "User")]
        public int UserID { get; set; }

        public virtual User User { get; set; }

        [Display(Name = "External Account")]
        public int ExternalAccountID { get; set; }

        public virtual ExternalAccount Account { get; set; }

        [Display(Name = "Security Token")]
        // what the hell is this? :D
            public int SecurityToken { get; set; }

        public override object EntityID
        {
            get { return UserExternalAccountTokenID; }
            set { UserExternalAccountTokenID = (int) value; }
        }
    }
}