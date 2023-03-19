using EF_Example.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_Example.Controllers.User
{
    [Authorize]
    [Route("api/login")]
    [ApiController]
    public class UserLoginControlle : ControllerBase
    {
        private readonly ExampleDbContext _context;

        public UserLoginControlle(ExampleDbContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Get all user information.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet(Name = "GetAllUserInfo")]
        public async Task<IEnumerable<UserLogin>> GetAllUserInfo()
        {
            return await _context.UserLogin.ToListAsync();
        }

        /// <summary>
        /// Get user information by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetData")]
        public async Task<ActionResult<UserLogin>> GetUserId(long id)
        {
            var UserLogin = await _context.UserLogin.FindAsync(id);
            if (UserLogin == null)
            {
                return NotFound();
            }
            return UserLogin;
        }


        /// <summary>
        /// Update user data by id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userLogin"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<UserLogin>> Update(long id, UserLogin userLogin)
        {
            if (id != userLogin.id)
                return BadRequest();

            _context.UserLogin.Update(userLogin);
            await _context.SaveChangesAsync();
            return Ok();
        }


        /// <summary>
        /// Update user data by id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userLogin"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult<UserLogin>> UpdateRole(UserLogin userLogin)
        {
            var userNameDb =await _context.UserLogin.Where(x => x.User_name.Contains(userLogin.User_name)).FirstOrDefaultAsync();
            if (userNameDb == null)
                return BadRequest($"User {userLogin.User_name} does not exist!");

            _context.UserLogin.Update(userLogin);
            await _context.SaveChangesAsync();
            return Ok($"Role for user {userLogin.User_name} was updated to {Enum.GetName(typeof(Roles), userLogin.User_Role)}");
        }

        /// <summary>
        /// Delete user by name.
        /// </summary>
        /// <param name="user_name"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserById(long id)
        {
            var userName = await _context.UserLogin.FindAsync(id);
            if (userName == null)
            {
                return NotFound();
            }

            _context.UserLogin.Remove(userName);
            await _context.SaveChangesAsync();
            return Ok();
        }

        /// <summary>
        /// Delete user by name.
        /// </summary>
        /// <param name="user_name"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteUserByName(UserLogin userLogin)
        {
            var userNameDb = await _context.UserLogin.Where(x => x.User_name.Contains(userLogin.User_name)).FirstOrDefaultAsync();
            if (userNameDb == null)
                return BadRequest($"User {userLogin.User_name} does not exist!");

            _context.UserLogin.Remove(userNameDb);
            await _context.SaveChangesAsync();
            return Ok($"User {userLogin.User_name} was deleted!");
        }

    }
}
