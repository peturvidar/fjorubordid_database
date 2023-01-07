using fjorubordid_database.Models;
using Microsoft.AspNetCore.Identity;

namespace fjorubordid_database.Data
{
    public class ApiUser : IdentityUser
    {
        public string? OwnerID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public ContactStatus Status { get; set; }


    }
    public enum ContactStatus
    {
        Submitted,
        Approved,
        Rejected
    }
}
