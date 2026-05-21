using Microsoft.AspNetCore.Identity;

namespace StudentDBWebApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
    }
}
