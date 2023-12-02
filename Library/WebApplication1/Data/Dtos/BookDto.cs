using Library.Models;
using System.ComponentModel.DataAnnotations;
using static MoviesAPi.Data.Dtos.LibraryBooksDto;

namespace Library.Data.Dtos;

    public class BookDto
    {
        public class CreateBookDto
        {

            [Required(ErrorMessage = "")] 
            [StringLength(80)]
            public string Name { get; set; }
            [Required(ErrorMessage = "Needs AuthorID")]
            public int AuthorId { get; set; }
            [Required(ErrorMessage = "")]
            public int Year { get; set; }
            public string Language { get; set; }
            public string Genre { get; set; }
        }

        public class ReadBookDto
        {
            public string Name { get; set; }
            public string Author { get; set; }
            public string Language { get; set; }
            public int Year { get; set; }
            public ICollection<ReadLibraryBooksDto> LibraryBook { get; set; }
        }   

        public class UpdateBookDto
        {
            [Required(ErrorMessage = "")]
            [StringLength(80)]
            public string Name { get; set; }
            [Required(ErrorMessage = "")]
            [StringLength(30)]
            public string Author { get; set; }
            [Required(ErrorMessage = "")]
            [StringLength(60)]
            public string Language { get; set; }
            [Required(ErrorMessage = "")]
            public int Year { get; set; }
        }
    }

