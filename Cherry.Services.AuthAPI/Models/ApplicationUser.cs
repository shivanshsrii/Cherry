using Microsoft.AspNetCore.Identity;

namespace Cherry.Services.AuthAPI.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
    }
}
