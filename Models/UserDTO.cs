using System.ComponentModel.DataAnnotations;

namespace fjorubordid_database.Models
{
    public class LoginUserDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)] public string? Email { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Your password is limited to {2} to {1} character", MinimumLength = 8)]

        public string? Password { get; set; }
    }
    public class UserDTO : LoginUserDTO
    {
       [DataType(DataType.PhoneNumber)] public string? PhoneNumber { get; set;}

        public ICollection<string>? Roles { get; set; }
    }
}
