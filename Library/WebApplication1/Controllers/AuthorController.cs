using AutoMapper;
using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Library.Data.Dtos.AuthorDto;

namespace Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private MysqlContext _context;
        private IMapper _mapper;

        public AuthorController(MysqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<ReadAuthorDto> GetAuthors()
        {
            return _mapper.Map<List<ReadAuthorDto>>(_context.Author);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthorsById(int id)
        {
            Author author = _context.Author.FirstOrDefault(author => author.Id == id);
            if (author != null)
            {
                ReadAuthorDto authorDto = _mapper.Map<ReadAuthorDto>(author);

                return Ok(authorDto);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddAuthors([FromBody] CreateAuthorDto authorDto)
        {
            Author authors = _mapper.Map<Author>(authorDto);
            _context.Author.Add(authors);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAuthorsById), new { Id = authors.Id }, authorDto);
        }

    }
}




