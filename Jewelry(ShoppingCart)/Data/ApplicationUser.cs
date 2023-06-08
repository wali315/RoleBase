using Microsoft.AspNetCore.Identity;

namespace Jewelry_ShoppingCart_.Data
{
    public class ApplicationUser:IdentityUser
    {
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public DateTime DateTime { get; set; }
        public string? ProfilePicture { get; set; }
    }
}
