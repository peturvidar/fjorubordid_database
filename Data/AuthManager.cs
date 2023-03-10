using AutoMapper;
using fjorubordid_database.Data.Interfaces;
using fjorubordid_database.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace fjorubordid_database.Data
{
    public class AuthManager : IAuthManager
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;
        private readonly IConfiguration _configuration;
        private ApiUser? _user;
        //private readonly SignInManager<ApiUser> _signInManager;
        
        public AuthManager(IMapper mapper, UserManager<ApiUser> userManager, IConfiguration configuration /*SignInManager<ApiUser> signInManager*/)
        {
            _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;
           // _signInManager = signInManager;
            
        }

        public async Task<AuthResponseDto> Login(LoginDto loginDto)
        {
            _user = await _userManager.FindByEmailAsync(loginDto.Email!);
            bool isValidUser = await _userManager.CheckPasswordAsync(_user!, loginDto.Password!);

            if (_user == null || isValidUser == false)
            {
                return null!;
            }
            var token = await GenerateToken();
            return new AuthResponseDto
            {
                Token = token,
                UserId = _user.Id
            };
        }

        /*private async Task<ApiUser> AuthenticateUser(LoginDto loginDto)
        {
            var result = await _signInManager.PasswordSignInAsync(loginDto.Email!, loginDto.Password!, false, lockoutOnFailure:false);
            if(result.Succeeded)
            {
                var userInfo = await _userManager.FindByEmailAsync(loginDto.Email!);
                return userInfo!;
            }
            return null!;
        }*/

        public async Task<IEnumerable<IdentityError>> Register(ApiUserDto apiUserDto)
        {
            var user = _mapper.Map<ApiUser>(apiUserDto);
            user.UserName = apiUserDto.Email;

            var result = await _userManager.CreateAsync(user, apiUserDto.Password!);

            if (result.Succeeded)
                await _userManager.AddToRoleAsync(user, "User");

            return result.Errors;
        }

        private async Task<string> GenerateToken()
        {
            
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("d5e0f15a-097e-46ad-a482-e7828e6447d9"));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var roles = await _userManager.GetRolesAsync(_user!);
            var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();

            var userClaims = await _userManager.GetClaimsAsync(_user!);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, _user.Email!), // sub = subject
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, _user.Email!),
                new Claim("uid", _user.Id)
            }
            .Union(userClaims).Union(roleClaims);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToInt32(_configuration
                ["JwtSettings:DurationInMinutes"])),
                signingCredentials: credentials

                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
