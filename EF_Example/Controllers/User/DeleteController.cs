using EF_Example.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_Example.Controllers.User
{
    [Authorize]
    [Route("api/user_delete")]
    [ApiController]
    public class DeleteController : Controller
    {
        private readonly ExampleDbContext _context;

        public DeleteController(ExampleDbContext context)
        {
            _context = context;
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
            var userNameDb =await _context.UserLogin.Where(x => x.User_name.Contains(userLogin.User_name)).FirstOrDefaultAsync();
            if (userNameDb == null)
                return BadRequest($"User {userLogin.User_name} does not exist!");

            _context.UserLogin.Remove(userNameDb);
            await _context.SaveChangesAsync();
            return Ok($"User {userLogin.User_name} was deleted!");
        }
    }
}
