using AutoMapper;
using Library.Data;
using Library.Data.Dtos;
using Library.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using static Library.Data.Dtos.BookDto;
using static Library.Data.Dtos.LibrariesDto;

namespace Library.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class BooksController : ControllerBase
    {

        private MysqlContext _context;
        private IMapper _mapper;

        public BooksController(MysqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpGet]
        public IEnumerable<ReadBookDto> GetAllBooks() 
        {

            return _mapper.Map<List<ReadBookDto>>(_context.Books.ToList());

        }

        [HttpGet("{id}")]
        public IActionResult GetBooksById(int id)
        {
            Book books = _context.Books.FirstOrDefault(b => b.Id == id);
            if (books != null)
            {
                ReadBookDto bookDto = _mapper.Map<ReadBookDto>(books);
                return Ok(bookDto);

            }
            return NotFound();
        }

       [HttpPost]
       public IActionResult AddBook([FromBody] CreateBookDto bookdto)
       {
            Book books = _mapper.Map<Book>(bookdto); //  convert o DTO recebio para o objeto
            _context.Books.Add(books);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetBooksById), new { id = books.Id }, books);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] UpdateBookDto bookDto)
        {
            var books = _context.Books.FirstOrDefault(b => b.Id == id);

            if (books == null) return NotFound();
            _mapper.Map(bookDto, books);
            _context.SaveChanges();

            return NoContent();
        }


        [HttpPatch("{id}")]
        public IActionResult UpdatePartialBook(int id, JsonPatchDocument<UpdateBookDto> patch)
        {
            var books = _context.Books.FirstOrDefault(b => b.Id == id);

            if (books == null) return NotFound();

            var bookToUpdate = _mapper.Map<UpdateBookDto>(books); // converte  o filme do banco para o model DTO

            patch.ApplyTo(bookToUpdate, ModelState); // se a mudanca for aplicada e tiver um modelo valido, e converte novamente para um filme

            if (!TryValidateModel(bookToUpdate))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(bookToUpdate, books);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooks(int id)
        {
            var books = _context.Books.FirstOrDefault(b => b.Id == id);

            if (books == null) return NotFound();
            _context.Remove(books);  // deleta o filme no banco de dados 
            _context.SaveChanges();
            return NoContent();
        }





    }
}
