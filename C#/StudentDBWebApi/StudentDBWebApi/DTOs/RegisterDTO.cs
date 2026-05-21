using System.ComponentModel.DataAnnotations;

namespace StudentDBWebApi.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Address { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
