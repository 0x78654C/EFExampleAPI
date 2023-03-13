using EF_Example.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_Example.Controllers
{
    [Authorize]
    [Route("api/books")]
    [ApiController]
    public class BookControler : ControllerBase
    {
        private readonly ExampleDbContext _context;

        public BookControler(ExampleDbContext context)
        {
            _context = context;
        }


        /// <summary>
        /// List all books in store.
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "ListBooks")]
        public async Task<IEnumerable<Books>> ListBooks() => await _context.Books.ToListAsync();

        /// <summary>
        /// Add books to db.
        /// </summary>
        /// <param name="bookData"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Books>> AddBooks(string bookName, Books bookData)
        {
            if (bookName != bookData.Book_Name)
                return BadRequest("Book alreadty exist!");

            _context.Books.Add(bookData);
            await _context.SaveChangesAsync();
            return Ok();
        }


        /// <summary>
        /// Update books by id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bookData"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<Books>> Update(long id, Books bookData)
        {
            if (id != bookData.id)
                return BadRequest();

            _context.Books.Update(bookData);
            await _context.SaveChangesAsync();
            return Ok();
        }


        /// <summary>
        /// Delete book data by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var bookData = await _context.Books.FindAsync(id);
            if (bookData == null)
            {
                return NotFound();
            }

            _context.Books.Remove(bookData);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
