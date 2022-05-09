using Core.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
   public class SecretaryViewModel
    {
        public AppUser User { get; set; }
        public IEnumerable<AppUser> Dentists { get; set; }
        public List<SelectListItem> DentistsSelectList { get;  set; }
    }
}
