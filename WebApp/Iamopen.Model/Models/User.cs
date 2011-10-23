﻿#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#endregion

namespace IAmOpen.Model.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "User Nickname is required!")]
        [MaxLength(50,ErrorMessage = "User Nickname cannot be longer than 50 characters!")]
        public string Nickname { get; set; }

        [Display(Name = "First Entry")]
        public DateTime FirstLoginDLC { get; set; }

        [Display(Name = "Enable Privacy")]
        public bool PrivacyOn { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<Institution> MyInstitutions { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public virtual ICollection<UserExternalAccountToken> UserExternalAccounts { get; set; }
    }
}