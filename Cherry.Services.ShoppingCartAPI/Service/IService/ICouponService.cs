using Cherry.Services.ShoppingCartAPI.Models.Dto;

namespace Cherry.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
