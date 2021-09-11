using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.DTOs
{
    public class GetWithProductDto : CategoryDto
    {

        public ICollection<ProductDto> Products { get; set; }


    }
}
