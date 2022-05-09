using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
   public class MüsteriBilgileri
    {
        [Key]
        public int MüsteriId { get; set; }
        public string Marka { get; set; }
        public int? MüsteriNo { get; set; }
        public string Plaka { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long? İsTelefon { get; set; }
        public long? EvTelefon { get; set; }
        public long? Ceptelefon { get; set; }
        public long? Fax { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public int? PostaKodu { get; set; }
        public string Ilce { get; set; }
        public string Şehir { get; set; }
        public DateTime? TrafigeCıkısTarihi { get; set; }
        public DateTime? SonServisTarih { get; set; }
        public string SasiNo { get; set; }
        public long? MotorNo { get; set; }
        public string AracTanımı { get; set; }
        public string AracRengi { get; set; }
        public decimal? Fiyat { get; set; }
    }
}
