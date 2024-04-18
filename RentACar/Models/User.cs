using Microsoft.AspNetCore.Identity;

namespace RentACar.Models
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string EGN { get; set; } = null!;
        public List<Request>? Requests { get; set; }
    }
}
