﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.DTOs
{
    public class ProductDto
    {

        public int Id { get; set; }


        [Required(ErrorMessage ="{0} alanı gereklidir.")]

        public string Name { get; set; }

        [Range(1,int.MaxValue,ErrorMessage ="{0} Stok alanı 1 den büyük olmalı.")]

        public int Stock { get; set; }

        [Range(1 , double.MaxValue, ErrorMessage = "{0} Stok alanı 1 den büyük olmalı.")]

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

      

     
    }
}
