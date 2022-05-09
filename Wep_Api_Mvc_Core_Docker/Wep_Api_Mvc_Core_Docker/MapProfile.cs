using AutoMapper;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wep_Api_Mvc_Core_Docker.DTOs;

namespace Wep_Api_Mvc_Core_Docker
{
    public class MapProfile : Profile
    {


        public MapProfile()
        {
            CreateMap<AdminDto, Admin>().ReverseMap();
            CreateMap<AnaDto, Ana>().ReverseMap();
            CreateMap<DuyuruDto, Duyuru>().ReverseMap();
            CreateMap<OdemelerDto, Odemeler>().ReverseMap();
            CreateMap<SiteSakiniDto, Satıs>().ReverseMap();
            CreateMap<SiteSakiniDto, SiteSakini>().ReverseMap();
        }
    }
}
