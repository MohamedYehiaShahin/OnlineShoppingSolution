using Microsoft.AspNetCore.Identity;

namespace Entities.Models.Request.Authentication
{
    public class RegisterUser :IdentityUser
    {
        public string? LastName { get; set; }
        public string? CompanyName { get; set; }
    }
}
