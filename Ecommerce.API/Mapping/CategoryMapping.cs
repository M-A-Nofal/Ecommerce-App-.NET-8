﻿using AutoMapper;
using Ecommerce.Core.DTOs;
using Ecommerce.Core.Entities.Product;

namespace Ecommerce.API.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<CategoryDTO, Category>().ReverseMap();
            CreateMap<UpdateCategoryDTO, Category>().ReverseMap();
        }
    }
}
