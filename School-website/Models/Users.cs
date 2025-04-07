using Microsoft.AspNetCore.Identity;

namespace School_website.Models
{
    public class Users:IdentityUser
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
