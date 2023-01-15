using System.ComponentModel.DataAnnotations;
using Fjorubordid_Api.Configuration;

namespace Fjorubordid_Api.Models.DTOs
{
    public class RegistrationResponse : AuthResult
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}