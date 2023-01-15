using System.ComponentModel.DataAnnotations;

namespace Fjorubordid_Api.Models.DTOs
{
    public class UserRegistrationDTO
    {
        [Required]
        public string? Username { get; set; }
        
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
