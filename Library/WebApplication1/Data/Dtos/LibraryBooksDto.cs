using static Library.Data.Dtos.BookDto;

namespace MoviesAPi.Data.Dtos
{
    public class LibraryBooksDto
    {
        public class CreateLibraryBooksDto
        {
            public int BookId { get; set; }
            public int LibrariesId { get; set; }
        }
        public class ReadLibraryBooksDto
        {
            public int BookId { get; set; }
            public int LibrariesId { get; set; }
            //public ReadBookDto Book { get; set; }

        }
    }
}