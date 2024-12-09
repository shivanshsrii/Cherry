using Cherry.Services.EmailAPI.Message;
using Cherry.Services.ShoppingCartAPI.Models.Dto;

namespace Cherry.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
