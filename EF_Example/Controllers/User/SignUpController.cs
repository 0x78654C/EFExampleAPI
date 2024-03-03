using EF_Example.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_Example.Controllers.User
{
    [Route("api/signup")]
    [ApiController]
    public class SignUpController : ControllerBase
    {
        private readonly ExampleDbContext _context;

        public SignUpController(ExampleDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Create user.
        /// </summary>
        /// <param name="userLogin"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<UserLogin>> CreateUser(UserLogin userLogin)
        {
            if ( await _context.UserLogin.Where(x => x.User_name == userLogin.User_name).AnyAsync())
            {
                return BadRequest($"User {userLogin.User_name} already exist!");
            }

            userLogin.Password = BCrypt.Net.BCrypt.HashPassword(userLogin.Password, BCrypt.Net.BCrypt.GenerateSalt(10));
            _context.UserLogin.Add(userLogin);
            await _context.SaveChangesAsync();
            return Ok($"User {userLogin.User_name} was created!");
        }

    }
}
