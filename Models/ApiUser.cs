using fjorubordid_database.Models;
using Microsoft.AspNetCore.Identity;

namespace fjorubordid_database.Data
{
    public class ApiUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

       // public List<OrderItem>? OrderItems { get; set; }
    }
}
