using EF_Example.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_Example.Controllers.BooksControllers
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
        public async Task<ActionResult<Books>> AddBooks(Books bookData)
        {
            var bookNameDb = await _context.Books.Where(x => x.Book_Name == bookData.Book_Name).FirstOrDefaultAsync();
            var isbnDb = await _context.Books.Where(x => x.ISBN == bookData.ISBN).FirstOrDefaultAsync();

            if (isbnDb != null)
                return BadRequest($"ISBN {bookData.ISBN} alreadty exist!");

            if (bookNameDb != null)
                return BadRequest($"Book '{bookData.Book_Name}' alreadty exist!");

            _context.Books.Add(bookData);
            await _context.SaveChangesAsync();
            return Ok($"Book {bookData.Book_Name} was stored!");
        }


        /// <summary>
        /// Update books by ISBN.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="bookData"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult<Books>> UpdateByISBN(Books bookData)
        {
            var isbnDb = await _context.Books.Where(x => x.ISBN == bookData.ISBN).FirstOrDefaultAsync();

            if (isbnDb == null)
                return BadRequest($"ISBN {bookData.ISBN} does not exist!");

            _context.Books.Update(bookData);
            await _context.SaveChangesAsync();
            return Ok();
        }


        /// <summary>
        /// Delete book data by id.
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteByISBN(Books bookData)
        {
            var isbnDb = _context.Books.Where(x => x.ISBN == bookData.ISBN).FirstOrDefault();

            if (isbnDb == null)
                return BadRequest($"ISBN {bookData.ISBN} does not exist!");

            _context.Books.Remove(isbnDb);
            await _context.SaveChangesAsync();
            return Ok($"Book with ISBN {isbnDb} was deleted!");
        }
    }
}
