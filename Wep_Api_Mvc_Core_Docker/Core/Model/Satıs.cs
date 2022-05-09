using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Model
{
    public class Satıs
    {
        [Key]
        public int SatısId { get; set; }

        [Column(TypeName = "character varying(250)")]
        [DisplayName("image Name")]
        public string imageName { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile imageFile { get; set; }

        [Column(TypeName = "character varying(250)")]
        public string Aciklama { get; set; }

    
        public int Fiyat { get; set; }
    }
}
