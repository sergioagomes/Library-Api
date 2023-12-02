using System.ComponentModel.DataAnnotations;
using static Library.Data.Dtos.AddressDto;
using static Library.Data.Dtos.BookDto;
using static MoviesAPi.Data.Dtos.LibraryBooksDto;

namespace Library.Data.Dtos
{
    public class LibrariesDto
    {
        public class CreateLibraryDto
        {
            [Required(ErrorMessage = "")]
            public string? Name { get; set; }
            public int AddressId { get; set; }
        }
        public class ReadLibaryDto
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public ReadAddressDto Address { get; set; }
            //public ICollection<ReadLibraryBooksDto> LibraryBook { get; set; }
        }
        public class UpdateLibraryDto
        {
            [Required(ErrorMessage = "")]
            public string? Name { get; set; }
        }

    }
}
