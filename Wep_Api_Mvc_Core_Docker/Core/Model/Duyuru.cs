using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Model
{
    public class Duyuru
    {
        [Key]
        public int DuyuruId { get; set; }


        [Column(TypeName = "character varying(250)")]
        public string Aciklama { get; set; }
    }
}
