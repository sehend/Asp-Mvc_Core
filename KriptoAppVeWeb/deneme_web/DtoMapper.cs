using AutoMapper;
using deneme_web.Dto;
using KriptoAppVeWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deneme_web
{
    internal class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<CategoryDto, sehend>().ReverseMap();
          
        }
    }
}
