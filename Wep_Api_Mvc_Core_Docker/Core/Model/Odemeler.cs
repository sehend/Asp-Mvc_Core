using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Model
{
    public class Odemeler
    {
        [Key]

        public int Id { get; set; }

        [Column(TypeName = "character varying(250)")]
        public string BlockNumarası { get; set; }

        [Column(TypeName = "character varying(250)")]
        public string Ad { get; set; }

        [Column(TypeName = "character varying(250)")]
        public string Soyad { get; set; }

        
        public int Tutar { get; set; }



        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        public DateTime Tarih { get; set; }

    }
}
