using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Fjorubordid_Api.Configuration;
using Fjorubordid_Api.Models.DTOs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens; 

namespace Fjorubordid_Api.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtConfig _jwtConfig;
       

        public AccountController(
            UserManager<IdentityUser> userManager,
            IOptionsMonitor<JwtConfig> optionsMonitor)
        {
            _userManager = userManager;
            _jwtConfig = optionsMonitor.CurrentValue;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationDTO user)
        {
            if(ModelState.IsValid)
            {
                
                var existingUser = await _userManager.FindByEmailAsync(user.Email!);

                if(existingUser != null)
                {
                    return BadRequest(new RegistrationResponse(){
                            Errors = new List<string>() {
                                "Email already in use"
                            },
                            Success = false
                    });
                }

                var newUser = new IdentityUser() { Email = user.Email, UserName = user.Username};
                var isCreated = await _userManager.CreateAsync(newUser, user.Password!);
                if(isCreated.Succeeded)
                {
                                        
                    var jwtToken =  GenerateJwtToken(newUser);

                   return Ok(new RegistrationResponse() {
                       Success = true,
                       Token = jwtToken
                   });
                } else {
                    return BadRequest(new RegistrationResponse(){
                            Errors = isCreated.Errors.Select(x => x.Description).ToList(),
                            Success = false
                    });
                }
            }

            return BadRequest(new RegistrationResponse(){
                    Errors = new List<string>() {
                        "Invalid payload"
                    },
                    Success = false
            });
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest user)
        {
            if(ModelState.IsValid)
            {
                var existingUser = await _userManager.FindByEmailAsync(user.Email!);

                if(existingUser == null) {
                        return BadRequest(new RegistrationResponse(){
                            Errors = new List<string>() {
                                "Wrong Email!"
                            },
                            Success = false
                    });
                }

                var isCorrect = await _userManager.CheckPasswordAsync(existingUser, user.Password!);

                if(!isCorrect) {
                      return BadRequest(new RegistrationResponse(){
                            Errors = new List<string>() {
                                "Wrong Password!"
                            },
                            Success = false
                    });
                }

                var jwtToken  =GenerateJwtToken(existingUser);

                return Ok(new RegistrationResponse() {
                    Success = true,
                    Token = jwtToken
                });
            }

            return BadRequest(new RegistrationResponse(){
                    Errors = new List<string>() {
                        "Invalid payload"
                    },
                    Success = false
            });
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Route("validatejwt")]
        public IActionResult ValidateJWT()
        {
            return Ok(true);
        }


        private string GenerateJwtToken(IdentityUser user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret!);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new []
                {
                    new Claim("Id", user.Id), 
                    new Claim(JwtRegisteredClaimNames.Email, user.Email!),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email!),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(6),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            return jwtToken;
        }
    }
}



