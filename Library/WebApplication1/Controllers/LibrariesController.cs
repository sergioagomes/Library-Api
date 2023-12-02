using AutoMapper;
using Library.Data;
using Library.Data.Dtos;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using static Library.Data.Dtos.LibrariesDto;

namespace Library.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class LibrariesController : ControllerBase
        {
            private MysqlContext _context;
            private IMapper _mapper;

            public LibrariesController(MysqlContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }


            [HttpPost]
            public IActionResult AddLibrary([FromBody] CreateLibraryDto libraryDto)
            {
                Libraries library = _mapper.Map<Libraries>(libraryDto);
                _context.Libraries.Add(library);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetLibrariesById), new { Id = library.Id }, libraryDto);
            }

            [HttpGet]
            public IEnumerable<ReadLibaryDto> GetLibraries()
            {
                return _mapper.Map<List<ReadLibaryDto>>(_context.Libraries.ToList());
            }

            [HttpGet("{id}")]
            public IActionResult GetLibrariesById(int id)
            {
                Libraries libraries = _context.Libraries.FirstOrDefault(l => l.Id == id);
                if (libraries != null)
                {
                    ReadLibaryDto libaryDto = _mapper.Map<ReadLibaryDto>(libraries);
                    return Ok(libaryDto);
                }
                return NotFound();
            }

            [HttpPut("{id}")]
            public IActionResult UpdateLibrary(int id, [FromBody] UpdateLibraryDto libaryDto)
            {
                Libraries libraries = _context.Libraries.FirstOrDefault(l  => l.Id == id);
                if (libraries == null)
                {
                    return NotFound();
                }
                _mapper.Map(libaryDto, libraries);
                _context.SaveChanges();
                return NoContent();
            }


            [HttpDelete("{id}")]
            public IActionResult DeleteCinema(int id)
            {
                Libraries libraries = _context.Libraries.FirstOrDefault(l => l.Id == id);
                if (libraries == null)
                {
                    return NotFound();
                }
                _context.Remove(libraries);
                _context.SaveChanges();
                return NoContent();
            }

        }
    }

