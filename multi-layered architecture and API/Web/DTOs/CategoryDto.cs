using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.DTOs
{
    public class CategoryDto
    {
        //Apide model ögeleri gelirken clint ta göstermek istemedigimiz veriler için kapsulleme ve diger degişle gizlem starup ve conturoller da ayarları var

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


    }
}
