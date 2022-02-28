using AutoMapper;
using deneme_web.Dto;
using KriptoAppVeWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deneme_web.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<sehend, CategoryDto>();

         
        }



    }
}
