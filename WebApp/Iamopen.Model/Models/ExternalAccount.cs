using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IAmOpen.Model.Models.Base;

namespace IAmOpen.Model.Models
{
    public class ExternalAccount : EquatableEntity
    {
        public int ExternalAccountID { get; set; }

        [Required(ErrorMessage = "Account Name is required!")]
        [MaxLength(50, ErrorMessage = "Account Name cannot be longer than 50 characters!")]
        public string Name { get; set; }

        public virtual ICollection<UserExternalAccountToken> UserExternalAccounts { get; set; }

        public override object EntityID
        {
            get { return ExternalAccountID; }
            set { ExternalAccountID = (int) value; }
        }
    }
}