using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.Models
{
    public class BookTest
    {
        [Fact]
        public void CreateValidBook()
        {
            //Arrange
            int Id = 1;
            string name = "OnePiece";
            string language = "Japones";
            int year = 1998;
            string Genre = "Adventure";
            int authorId = 1;

            //act
            var book = new Book()
            {
                Id = Id,
                Name = name,
                Language = language,
                Year = year,
                Genre = Genre,
                AuthorId = authorId
            };

            //Assert
            Assert.Equal(Id, book.Id);
            Assert.Equal(name, book.Name);
            Assert.Equal(language, book.Language);
            Assert.Equal(year, book.Year);
            Assert.Equal(Genre, book.Genre);
            Assert.Equal(authorId, book.AuthorId); 
        }
    }
}
