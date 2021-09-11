using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cok_Katmanlı_Mimari.API_NLayerProject_.DTOs
{
    public class GetWithProductDto : CategoryDto
    {

        public ICollection<ProductDto> Products { get; set; }


    }
}
