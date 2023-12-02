using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.Models
{
    public class AuthorTest
    {
        [Fact]
        public void TestCreateAuthor()
        {
            //Arrange
            int Id = 1;
            string name = "Oda";
            string country = "Japao";
            string birth = "?????";
            //Act

            var author = new Author()
            {
                Id = Id,
                Name = name,
                Country = country,
                Birth = birth
            };

            //Assert
            Assert.Equal(author.Id, Id);
        }
    }
}
