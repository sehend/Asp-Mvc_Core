using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class PasswordChangeViewModel
    {
        [Display(Name = "Eski Şifreniz")]
        [Required(ErrorMessage = "Eski Şifreniz Gereklidir")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "Şifreniz En Az Karakterli Olmalıdır")]
        public string PasswordOld { get; set; }


        [Display(Name = "Yeni Şifreniz")]
        [Required(ErrorMessage = "Yeni Şifreniz Gereklidir")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "Şifreniz En Az Karakterli Olmalıdır")]
        public string PasswordNew { get; set; }

        [Display(Name = "Onay Yeni Şifreniz Tekrar Giriniz")]
        [Required(ErrorMessage = "Onay Yeni Şifreniz Tekrarı  Gereklidir")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "Şifreniz En Az Karakterli Olmalıdır")]
        [Compare("PasswordNew", ErrorMessage = "Yeni Şifreniz Ve onay Şifreniz Birbirinden Farklıdır")]
        public string PasswordConfim { get; set; }

    }
}
