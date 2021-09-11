﻿using AutoMapper;
using Web.DTOs;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();

            CreateMap<CategoryDto, Category>();

            CreateMap<Category, GetWithProductDto>();

            CreateMap<GetWithProductDto, Category>();

            CreateMap<Product, ProductDto>();

            CreateMap<ProductDto, Product>();

            CreateMap<Product,ProductWithCategoryDto>();

            CreateMap<ProductWithCategoryDto,Product>();
        }



    }
}
