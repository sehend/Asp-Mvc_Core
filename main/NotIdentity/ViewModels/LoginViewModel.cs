using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotIdentity.ViewModels
{
    public class LoginViewModel
    {   
        [Display(Name ="Email Adresiniz")]
        [Required(ErrorMessage ="Email Alanı Gereklidir")]
        [EmailAddress]
        public string Email { get; set; }


        [Display(Name = "Şifreniz")]
        [Required(ErrorMessage = "Şifre Alanı Gereklidir")]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        public bool RememberMe { get; set; }


    }
}
