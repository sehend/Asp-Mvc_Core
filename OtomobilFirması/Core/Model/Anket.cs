using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
  public  class Anket
    {  [Key]
        public int AnketId { get; set; }
        public DateTime? TekrarAramaTarihiCevapsız { get; set; }
        public decimal? FiatTekilifiVerildi { get; set; }
        public DateTime? FiatTekifiHatırlatmaTarihi { get; set; }
        public decimal? Fiat { get; set; }
        public string RandevuAldimi { get; set; }
        public DateTime? RandevuTarihi { get; set; }
        public string RandevuDanişmanı { get; set; }
        public string RandevuNedeni { get; set; }
        public string BaskaSevis { get; set; }
        public string YetkilimiÖzelmi { get; set; }
        public string İslemBaskaServisİsmi { get; set; }
        public DateTime? İslemBaskaServisYapılısTarihi { get; set; }
        public string Sonuc { get; set; }
        public string DosyaDurumu { get; set; }
    }
}
