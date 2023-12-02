using AutoMapper;
using Library.Models;
using static Library.Data.Dtos.LibrariesDto;

namespace Library.Profiles
{
    public class LibraryProfile : Profile
    {
        public LibraryProfile() 
        {

            CreateMap<CreateLibraryDto, Libraries>();
            CreateMap<Libraries, ReadLibaryDto>()
                .ForMember(LibrariesDto => LibrariesDto.Address, opt => opt.MapFrom(libraries => libraries.Address));
                //.ForMember(LibrariesDto => LibrariesDto.LibraryBook, opt => opt.MapFrom(libraries => libraries.LibraryBook));

            CreateMap<Libraries, UpdateLibraryDto>();
        }
    }
}
