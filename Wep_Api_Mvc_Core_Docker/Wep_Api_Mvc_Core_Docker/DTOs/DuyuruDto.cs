﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Wep_Api_Mvc_Core_Docker.DTOs
{
   public class DuyuruDto
    {
        [Column(TypeName = "character varying(250)")]
        public string Aciklama { get; set; }
    }
}
