using fjorubordid_database.Models;
using Microsoft.AspNetCore.Identity;

namespace fjorubordid_database.Data.Interfaces
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto apiUserDto);

        Task<AuthResponseDto> Login(LoginDto loginDto);
    }
}
