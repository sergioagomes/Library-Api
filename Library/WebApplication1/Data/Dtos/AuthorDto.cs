namespace Library.Data.Dtos
{
    public class AuthorDto
    {
        public class CreateAuthorDto
        {
            public string Name { get; set; }
            public string Country { get; set; }
            public string Birth {  get; set; }

        }

        public class ReadAuthorDto
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }

        public class UpdateAuthorDto
        {
            public string Name { get; set; }

        }
    }
}
