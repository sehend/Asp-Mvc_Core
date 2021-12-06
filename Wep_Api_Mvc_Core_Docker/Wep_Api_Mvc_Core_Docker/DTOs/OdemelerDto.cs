using System;
using System.Collections.Generic;
using System.Text;

namespace Wep_Api_Mvc_Core_Docker.DTOs
{
   public class OdemelerDto
    {
        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        public DateTime Tarih { get; set; }
    }
}
