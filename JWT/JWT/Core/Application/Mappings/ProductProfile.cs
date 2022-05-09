using AutoMapper;
using JWT.Core.Application.Dto;
using JWT.Core.Domain;

namespace JWT.Core.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            this.CreateMap< Product, ProductListDto>().ReverseMap();
        }
    }
}
