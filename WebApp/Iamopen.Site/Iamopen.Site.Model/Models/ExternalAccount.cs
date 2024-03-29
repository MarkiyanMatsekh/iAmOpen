﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IAmOpen.Site.Model.Models.Base;

namespace IAmOpen.Site.Model.Models
{
    public class ExternalAccount : EntityWithID<int>
    {
        [Required(ErrorMessage = "Account Name is required!")]
        [MaxLength(50, ErrorMessage = "Account Name cannot be longer than 50 characters!")]
        public string Name { get; set; }

        public virtual ICollection<UserExternalAccountToken> UserExternalAccounts { get; set; }
    }
}