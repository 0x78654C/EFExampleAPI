using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_Example.Controllers
{
    [Route("api/data")]
    [ApiController]
    public class UserDataController: ControllerBase
    {
        private readonly ExampleDbContext _context;

        public UserDataController(ExampleDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all data.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet(Name = "GetAllData")]
        public async Task<IEnumerable<UserData>> GetAllData()
        {
            return await _context.UserData.ToListAsync();
        }


        /// <summary>
        /// Get user data by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<UserData>> GetData(long id)
        {
            var userData = await _context.UserData.FindAsync(id);
            if (userData == null)
            {
                return NotFound();
            }
            return userData;
        }


        /// <summary>
        /// Add data to db.
        /// </summary>
        /// <param name="userLogin"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<UserData>> AddData(UserData userData)
        {
            _context.UserData.Add(userData);
            await _context.SaveChangesAsync();
            return Ok();
        }

        /// <summary>
        /// Update user data by user_id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userLogin"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<UserData>> Update(long id, UserData userData)
        {
            if (id != userData.id)
                return BadRequest();

            _context.UserData.Update(userData);
            await _context.SaveChangesAsync();
            return Ok();
        }

        /// <summary>
        /// Delete data by id.
        /// </summary>
        /// <param name="user_name"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete (long id)
        {
            var userData = await _context.UserData.FindAsync(id);
            if (userData == null)
            {
                return NotFound();
            }

            _context.UserData.Remove(userData);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
