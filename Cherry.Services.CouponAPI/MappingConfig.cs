using AutoMapper;
using Cherry.Services.CouponAPI.Models;
using Cherry.Services.CouponAPI.Models.Dto;

namespace Cherry.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig=new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;     
        }
    }
}
