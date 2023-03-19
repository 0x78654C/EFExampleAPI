using EF_Example.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_Example.Controllers
{
   // [Authorize]
    [Route("api/roles")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly ExampleDbContext _context;

        public RoleController(ExampleDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// List all books in store.
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "ListRoles")]
        public async Task<IEnumerable<Role>> ListBooks() => await _context.Roles.ToListAsync();

    }
}
