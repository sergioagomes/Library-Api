using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class BooksSession
    {
        public int? BookId { get; set; }
        public virtual Book Book { get; set; }
        public int? LibrariesId { get; set; }
        public virtual Libraries Libraries { get; set; }

    }
}
