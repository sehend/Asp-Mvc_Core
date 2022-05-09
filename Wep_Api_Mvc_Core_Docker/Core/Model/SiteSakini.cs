using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Model
{
   public class SiteSakini
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "character varying(250)")]
        public string KonutNumarası { get; set; }

        [Column(TypeName = "character varying(250)")]
        public string Ad { get; set; }

        [Column(TypeName = "character varying(250)")]
        public string SoyAd { get; set; }

        [Column(TypeName = "character varying(250)")]
        public string Tc { get; set; }


    }
}
