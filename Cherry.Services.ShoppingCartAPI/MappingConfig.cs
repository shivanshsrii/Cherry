using AutoMapper;
using Cherry.Services.ShoppingCartAPI.Models;
using Cherry.Services.ShoppingCartAPI.Models.Dto;

namespace Cherry.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig=new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
            });
            return mappingConfig;     
        }
    }
}
