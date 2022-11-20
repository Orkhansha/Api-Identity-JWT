using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.Account;
using ServiceLayer.DTOs.Book;
using ServiceLayer.DTOs.Product;

namespace ServiceLayer.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductCreateDto, Product>();
            CreateMap<Product, ProductListDto>();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();

            CreateMap<BookCreateDto, Book>();
            CreateMap<Book, BookListDto>();
            CreateMap<BookUpdateDto, Book>().ReverseMap();
            CreateMap<RegisterDto, AppUser>().ReverseMap();
        }
    }
}
