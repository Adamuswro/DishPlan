using AutoMapper;
using DishPlan.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DishPlan.Server.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Ingredient, IngredientDTO>().ReverseMap();
            CreateMap<ReciepieIngredient, ReciepieIngredientDTO>().ReverseMap();
            CreateMap<Reciepie, ReciepieDTO>().ReverseMap();
        }
    }
}