using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Libraries
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; } // doing relationship 1 : 1 with address
        public virtual Address Address { get; set; }
        public virtual ICollection<LibraryBooks> LibraryBook { get; set; }
    }
}
