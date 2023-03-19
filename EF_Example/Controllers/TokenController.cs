using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using EF_Example.Models;

namespace EF_Example.Controllers
{
    /// <summary>
    /// JWT token generator controler
    /// </summary>

    [Route("api/token")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly ExampleDbContext _context;

        public TokenController(IConfiguration config, ExampleDbContext context)
        {
            _configuration = config;
            _context = context;
        }

        /// <summary>
        /// Post user data (user name, password) to get JWT token.
        /// </summary>
        /// <param name="_userData"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> Post(UserLogin _userData)
        {
            if (_userData?.Password == null)
            {
                return BadRequest();
            }

            var user = await GetUser(_userData.User_name);


            if (user == null || user.Password != _userData.Password) // password should be hashed and should validate hash would recommend bcrypt
            {
                return BadRequest("Invalid credentials");
            }

            //create claims details based on the user information
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                new Claim("User_name", user.User_name),
                new Claim("password", user.Password),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: signIn);

            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }

        private async Task<UserLogin?> GetUser(string email)
            => await _context.UserLogin.FirstOrDefaultAsync(u => u.User_name.ToLower() == email.ToLower());
        
    }
}
