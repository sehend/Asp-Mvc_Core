﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotIdentity.ViewModels
{
    public class UserViewModel
    {

        public string Id { get; set; }

        [Required(ErrorMessage = "Kullanıcı ismi gerekldir.")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Display(Name = "Tel No:")]
      
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email adresi gereklidir.")]
        [Display(Name = "Email Adresiniz")]
        [EmailAddress(ErrorMessage = "Email adresiniz doğru formatta değil")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifreniz gereklidir.")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Doğum tarihi")]
        [DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }

        public string Picture { get; set; }

        public string Ctiy { get; set; }

        public int Gneder { get; set; }
    }


}
