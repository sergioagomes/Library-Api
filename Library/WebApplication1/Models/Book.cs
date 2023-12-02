using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "")]
        public string Name { get; set; }
        public string Language { get; set; }
        public int   Year { get; set; }
        public string Genre { get; set; }
        public int AuthorId { get; set; }
        public virtual ICollection<LibraryBooks> LibraryBook { get; set; }
        public virtual Author Author { get; set; }
    }
}
