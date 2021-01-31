using Auth.JWTv01.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Auth.JWTv01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IConfiguration _config;

        public AuthController(IConfiguration config)
        {
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost, Route("login")]
        public IActionResult Login([FromBody] LoginVM loginModel)
        {
            if (loginModel == null)
            {
                return BadRequest("Invalid request");
            }

            if (IsLogin(loginModel.UserName, loginModel.Password))
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                     issuer: _config["Jwt:Issuer"],
                     audience: _config["Jwt:Audience"],
                     claims: new List<Claim>(),
                     expires: DateTime.Now.AddMinutes(30),
                     signingCredentials: signinCredentials
                 );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString });
            }
            else
            {

                return Unauthorized();
            }



        }

        public bool IsLogin(string username, string password)
        {
            bool result = username == "mahedee" && password == "pass123" ? true : false;
            return result;
        }
    }
}
