using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        [StringLength(12, MinimumLength = 1)]
        public string Username { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 4)]
        public string Password { get; set; }
    }
}