using AutoMapper;
using Library.Api.Resources;
using Library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;

        public BookController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }
        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Book>>> GetAllBooks()
        {
            var books = await _bookService.GetAllBooksAsync();
            var bookResource = _mapper.Map<IEnumerable<Book>, IEnumerable<BookResource>>(books);
            return Ok(bookResource);
        }

        [HttpGet("AllBooks")]
        public async Task<ActionResult<IEnumerable<Book>>> GetAllBooksOrderByValue(string value)
        {
            var books = await _bookService.GetAllBooksOrderByValue(value);
            var bookResource = _mapper.Map<IEnumerable<Book>, IEnumerable<BookResource>>(books);
            return Ok(bookResource);
        }
    }
}
