using Cherry.Services.ShoppingCartAPI.Models.Dto;

namespace Cherry.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
