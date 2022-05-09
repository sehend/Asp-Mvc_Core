using AutoMapper;
using JWT.Core.Application.Dto;
using JWT.Core.Domain;

namespace JWT.Core.Application.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            this.CreateMap<Category, CategoryListDto>().ReverseMap();
        }
    }
}
