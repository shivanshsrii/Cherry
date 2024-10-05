using Cherry.Web.Models;

namespace Cherry.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string couponId);
        Task<ResponseDto?> GetAllCouponsAsync();
        Task<ResponseDto?> GetCouponsByIdAsync(int id);
        Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDto);
        Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto);
        Task<ResponseDto?> DeleteCouponsAsync(int id);
    }
}
