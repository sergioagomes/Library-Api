using AutoMapper;
using Library.Models;
using static MoviesAPi.Data.Dtos.LibraryBooksDto;

namespace Library.Profiles
{
    public class LibraryBooksProfile : Profile
    {
        public LibraryBooksProfile()
        {
            CreateMap<CreateLibraryBooksDto, LibraryBooks>();
            CreateMap<LibraryBooks, ReadLibraryBooksDto>();
                /*.ForMember(LibraryBooksDto => LibraryBooksDto.Book, opt => opt.MapFrom(lb => lb.Book))
                .ForMember(LibraryBooksDto => LibraryBooksDto., opt => opt.MapFrom(lb => lb.Book));*/
        
        }
    }
}
