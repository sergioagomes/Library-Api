using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Author
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Birth { get; set; }
        public virtual ICollection<Book> Books { get; set; }
            
    }
}
