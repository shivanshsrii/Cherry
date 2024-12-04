using Cherry.Services.EmailAPI.Data;
using Cherry.Services.EmailAPI.Models;
using Cherry.Services.ShoppingCartAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Cherry.Services.EmailAPI.Services
{
    public class EmailService : IEmailService
    {
        private DbContextOptions<AppDbContext> _dbOptions;

        public EmailService(DbContextOptions<AppDbContext> dbOptions)
        {
            _dbOptions = dbOptions;
        }

        public async Task EmailCartAndLog(CartDto cartDto)
        {
             StringBuilder message=new StringBuilder();

            message.AppendLine("<br/>Cart Email Requested");
            message.AppendLine("<br/>Total" + cartDto.CartHeader.CartTotal);
            message.Append("<br/>");
            message.Append("<ul>");
            foreach(var item in cartDto.CartDetails)
            {
                message.Append("<li>");
                message.Append(item.Product.Name  + "x" + item.Count);
                message.Append("</li>");
            }
            message.Append("</ul");
            await LogAndEmail(message.ToString(),cartDto.CartHeader.Email);
        }

        public async Task RegisterUserEmailAndLog(string email)
        {
            string message = "User Registration Successfull. <br/> Email " + email;
            await LogAndEmail(message,"admin3@gmail.com");  
        }

        private async Task<bool> LogAndEmail(string message, string email)
        {
            try
            {
                EmailLogger emailLog = new()
                {
                    Email = email,
                    EmailSent = DateTime.Now,
                    Message = message
                };
                await using var _db=new AppDbContext(_dbOptions);
                _db.EmailLoggers.Add(emailLog);
                await _db.SaveChangesAsync();   
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
