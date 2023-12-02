using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class MysqlContext : DbContext
    {
        public MysqlContext(DbContextOptions<MysqlContext> options) : base(options) 
        {
        }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //LibraryBooks
            builder.Entity<LibraryBooks>()
            .HasKey(bs => new { bs.BookId, bs.LibrariesId });

            builder.Entity<LibraryBooks>()
                .HasOne(bs => bs.Libraries)
                .WithMany(l => l.LibraryBook)
                .HasForeignKey(bs => bs.LibrariesId);

            builder.Entity<LibraryBooks>()
                .HasOne(bs => bs.Book)
                .WithMany(b => b.LibraryBook)
                .HasForeignKey(bs => bs.BookId);

            //Author
            builder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);

            //Adress
            builder.Entity<Address>()
                .HasOne(address => address.Libraries)
                .WithOne(l => l.Address)
                .OnDelete(DeleteBehavior.Restrict); 
        }

        // prop of acess
        public DbSet<Book> Books { get; set; }
        public DbSet<Libraries> Libraries { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<LibraryBooks> LibraryBook { get; set; }
        public DbSet<Author> Author { get; set; }

    }
}
