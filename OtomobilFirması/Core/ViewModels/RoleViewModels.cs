using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class RoleViewModels
    {
        [Display(Name = "Role İsmi")]
        [Required(ErrorMessage = "Role Tanımlamak Gereklidir")]
        public string Name { get; set; }

        public string Id { get; set; }
    }
}
