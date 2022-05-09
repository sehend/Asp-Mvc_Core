using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
   public class AracBilgileri
    {
        [Key]
        public int AracId { get; set; }
        public string Kaynak { get; set; }
        public string Marka { get; set; }
        public string Sasi { get; set; }
        public long? PlakaKodu { get; set; }
        public string Model { get; set; }
        public string AraçTanımı { get; set; }
        public DateTime? ModelYıl { get; set; }
        public string Seri { get; set; }
        public string Renk { get; set; }
        public string Plaka { get; set; }
        public string Motor { get; set; }
        public int? Km { get; set; }
        public DateTime? SonGelisTarihi { get; set; }
        public DateTime? TrafigeCikalıKaçYilOlmus { get; set; }
        public int? IsEmriAdeti { get; set; }
        public int? GenelToplam { get; set; }
        public DateTime? SonFaturaTarihi { get; set; }
        public DateTime? GeçenGünSayısı { get; set; }
        public string Aciklama { get; set; }
        public decimal? Fiat { get; set; }

    }
}
