using AutoMapper;
using Library.Data.Dtos;
using Library.Models;
using static Library.Data.Dtos.BookDto;

namespace Library.Profiles;

public class BookProfile : Profile
{
    public BookProfile()
    {
        CreateMap<CreateBookDto, Book>();
        CreateMap<UpdateBookDto, Book>();
        CreateMap<Book, UpdateBookDto>();
        CreateMap<Book, ReadBookDto>()
            .ForMember(BookDto => BookDto.Author, opt => opt.MapFrom(book => book.Author.Name))
            .ForMember(BookDto => BookDto.LibraryBook, opt => opt.MapFrom(book => book.LibraryBook));
    }
}
