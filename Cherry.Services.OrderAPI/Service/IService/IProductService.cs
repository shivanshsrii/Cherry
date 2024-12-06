using Cherry.Services.OrderAPI.Models.Dto;

namespace Cherry.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
