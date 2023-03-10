using AutoMapper;
using fjorubordid_database.Data;
using fjorubordid_database.Data.Interfaces;
using fjorubordid_database.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace fjorubordid_database.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthManager _authManager;


        public AccountController(IAuthManager authManager)
        {
            _authManager= authManager;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public async Task<ActionResult> Register([FromBody] ApiUserDto apiUserDto)
        {
            var errors = await _authManager.Register(apiUserDto);
            if (errors.Any())
            {
                foreach (var error in errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);

                   if (error.Code == "DuplicateUserName")
                    {
                        return Conflict(ModelState);
                    }
                    else
                    {
                        return BadRequest(ModelState);
                    }
                }
               }
            return Ok();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> Login([FromBody] LoginDto loginDto)
        {
            var authResponse = await _authManager.Login(loginDto);

            if (authResponse == null)
                return Unauthorized();

            return Ok(authResponse);
        }

    }
}
