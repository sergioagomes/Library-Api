using AutoMapper;
using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using static Library.Data.Dtos.LibrariesDto;
using static MoviesAPi.Data.Dtos.LibraryBooksDto;

namespace Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryBooksController : ControllerBase
    {
        private MysqlContext _context;
        private IMapper _mapper;

        public LibraryBooksController(MysqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddLibrary([FromBody] CreateLibraryBooksDto librarybooksDto)
        {
            LibraryBooks libraryBook = _mapper.Map<LibraryBooks>(librarybooksDto);
            _context.LibraryBook.Add(libraryBook);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetSessions), new { bookId = libraryBook.BookId, librariesId = libraryBook.LibrariesId}, libraryBook);
        }
   

        [HttpGet]
        public IEnumerable<ReadLibraryBooksDto> GetSessions()
        {
            return _mapper.Map<List<ReadLibraryBooksDto>>(_context.LibraryBook.ToList());
        }

    }
}
