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
            if (_userData != null && _userData.Password != null)
            {
                var user = await GetUser(_userData.User_name, _userData.Password);

                if (user != null)
                {
                    //create claims details based on the user information
                    var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("user_id", user.id.ToString()),
                        new Claim("User_name", user.User_name),
                        new Claim("Login_date)", user.Login_date.ToString())
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
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        private async Task<UserLogin> GetUser(string email, string password)
        {
            return await _context.UserLogin.FirstOrDefaultAsync(u => u.User_name == email && u.Password == password);
        }
    }
}
