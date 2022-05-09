using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
   public  class Detay
    {
        public int? Id { get; set; }
        public int? AracId { get; set; }

        public virtual AracBilgileri Arac { get; set; }
        public virtual MüsteriBilgileri IdNavigation { get; set; }
    }
}
