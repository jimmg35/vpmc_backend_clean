using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using System.Diagnostics;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using vpmc_backend.Areas.Identity.Data;
using System.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using vpmc_backend.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace vpmc_backend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class JwtAuthController : ControllerBase
    {
        private readonly UserManager<vpmc_backendUser> _userManager;
        private readonly SignInManager<vpmc_backendUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly JwtAuthenticator _jwtAuthenticator;


        public JwtAuthController(JwtAuthenticator jwtAuthenticator,
                                 SignInManager<vpmc_backendUser> signInManager,
                                 UserManager<vpmc_backendUser> userManager,
                                 RoleManager<IdentityRole> roleManager)
        {
            _jwtAuthenticator = jwtAuthenticator;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _jwtAuthenticator.injectDbContext(userManager);
        }


        [AllowAnonymous]
        [HttpGet("validate")]
        public IActionResult validate(string token)
        {
            if(token == null)
            {
                return StatusCode(422, "Token can't be null");
            }

            string statusCode = _jwtAuthenticator.validate(token);
            if(statusCode != "400")
            {
                return StatusCode(200, statusCode);
            }
            else
            {
                return StatusCode(400, "Can't decode this Jwt token!");
            }
        }


        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> register([FromBody] JwtUserRegister jwtUserRegister)
        {
            var data = new vpmc_backendUser
            {
                UserName = jwtUserRegister.username,
                Email = jwtUserRegister.email,
                PhoneNumber = jwtUserRegister.phoneNumber
            };
            var result = await _userManager.CreateAsync(data, jwtUserRegister.password);

            Debug.WriteLine("=================================");
            Debug.WriteLine(result);
            if (result.Succeeded)
            {

                var currentUser = await _userManager.FindByNameAsync(jwtUserRegister.username);
                var roleresult = await _userManager.AddToRoleAsync(currentUser, "User");


                return Ok();
            }
            return StatusCode(409, result.ToString());
        }


        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> authenticate([FromBody] JwtUserCred jwtUserCred) 
        {
            var result = await _signInManager.PasswordSignInAsync(jwtUserCred.username, jwtUserCred.password, false, false);
            
            if (result.Succeeded)
            {
                string user_token = _jwtAuthenticator.authenticate(jwtUserCred.username, jwtUserCred.password).Result;
                return Ok(user_token);
            }
            return Unauthorized();
        }

        [Authorize]
        [HttpPost("setcookie")]
        public async Task<ActionResult> SignInWithCookie()
        {
            await HttpContext.SignInAsync(
              CookieAuthenticationDefaults.AuthenticationScheme,
              HttpContext.User);

            return NoContent();
        }

    }
}
