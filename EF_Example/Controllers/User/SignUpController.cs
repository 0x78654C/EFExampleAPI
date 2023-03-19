﻿using EF_Example.Models;
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
            var userName = await _context.UserLogin.Where(x => x.User_name == userLogin.User_name).FirstOrDefaultAsync();
            if (userName != null)
            {
                return BadRequest($"User {userLogin.User_name} already exist!");
            }
            _context.UserLogin.Add(userLogin);
            await _context.SaveChangesAsync();
            return Ok($"User {userLogin.User_name} was created!");
        }

    }
}
