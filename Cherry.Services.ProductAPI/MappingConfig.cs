using AutoMapper;
using Cherry.Services.ProductAPI.Models;
using Cherry.Services.ProductAPI.Models.Dto;

namespace Cherry.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig=new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;     
        }
    }
}
