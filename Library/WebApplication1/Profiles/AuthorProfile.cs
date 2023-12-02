using AutoMapper;
using Library.Models;
using static Library.Data.Dtos.AuthorDto;

namespace Library.Profiles
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<CreateAuthorDto, Author>();
            CreateMap<Author, ReadAuthorDto>();
        }
    }
}
