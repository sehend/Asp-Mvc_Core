using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Wep_Api_Mvc_Core_Docker.DTOs
{
   public class SiteSakiniDto
    {
        [Column(TypeName = "character varying(250)")]
        public string Ad { get; set; }

        [Column(TypeName = "character varying(250)")]
        public string SoyAd { get; set; }
    }
}
