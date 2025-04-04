using app_books.Dto;
using app_books.Entity;
using AutoMapper;

namespace app_books.Config
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Author, AuthorResponse>();
            CreateMap<AuthorRequest, Author>();
        }
    }
}
