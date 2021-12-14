using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using vpmc_backend.Models;
using vpmc_backend.Areas.Identity.Data;
using System.Diagnostics;
using Newtonsoft.Json;

namespace vpmc_backend.Controllers
{
    public class JwtAuthenticator
    {
        // This is fake user database, replace when user tables are onboard.
        private readonly IDictionary<string, string> staticUserData = new Dictionary<string, string>
        {
            { "jimmg35", "jim60308" }, 
            { "Robert", "123456" },
            { "Andy", "123456" }
        };
        private readonly IDictionary<string, string> algorithmSet = new Dictionary<string, string>
        {
            { "sha256", SecurityAlgorithms.HmacSha256Signature }, 
            { "sha384", SecurityAlgorithms.HmacSha384Signature }, 
            { "sha512", SecurityAlgorithms.HmacSha512Signature }
        };
        private readonly string encryptionAlgorithm;
        private readonly string encryptionKey;
        private UserManager<vpmc_backendUser> _userManager;

        public JwtAuthenticator(string key, string algorithm) //, SignInManager<vpmc_backendUser> signInManager
        {
            encryptionKey = key;
            encryptionAlgorithm = algorithm;
        }

        public void injectDbContext(UserManager<vpmc_backendUser> userManager)
        {
            _userManager = userManager;
        }



        // This method will output a token(string).
        public async Task<string> authenticate(string username, string password)
        {
            vpmc_backendUser user = await _userManager.FindByNameAsync(username);
            IList<string> roles = await _userManager.GetRolesAsync(user);
            List<string> rolesList = roles as List<string>;

            JwtSecurityTokenHandler myTokenHandler = new JwtSecurityTokenHandler();
            byte[] tokenKey = Encoding.ASCII.GetBytes(encryptionKey);


            Debug.WriteLine("UserID", user.Id);
            Debug.WriteLine(rolesList.Count);
            Debug.WriteLine("UserName", username);
            
            Debug.WriteLine("===================  ======");

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim("UserID", user.Id),
                    new Claim("UserName", username),
                    new Claim("UserRole", rolesList[0])
                }),
                Expires = DateTime.UtcNow.AddHours(3),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                    algorithmSet[encryptionAlgorithm]
                )
            };
            SecurityToken outputToken = myTokenHandler.CreateToken(tokenDescriptor);
            return myTokenHandler.WriteToken(outputToken);
        }

        // Validate the Jwt Token, output data from payload
        public string validate(string token)
        {
            var key = Encoding.ASCII.GetBytes(encryptionKey);
            var handler = new JwtSecurityTokenHandler();
            var validations = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };
            try
            {
                var claims = handler.ValidateToken(token, validations, out var tokenSecure);
                string outputString = "{";
                int count = 0;
                foreach (Claim claim in claims.Claims)
                {
                    if(count == (claims.Claims.Count()-1))
                    {
                        outputString += claim.Type + ":" + claim.Value + "}";
                        break;
                    }
                    outputString += claim.Type + ":" + claim.Value + ",";
                    count++;
                }
                return outputString;
            }
            catch
            {
                return "400";
            }
            
        }
    }
}
