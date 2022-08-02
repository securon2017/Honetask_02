using AutoMapper;
using Library.Api.Resources;
using Library.Core.Models;

namespace Library.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<Book, BookResource>();
            CreateMap<Review, ReviewResource>();
            CreateMap<Rating, RatingResource>();

            // Resource to Domain
            CreateMap<BookResource, Book>();
            CreateMap<ReviewResource, Review>();
            CreateMap<RatingResource, Rating>();
        }
    }
}
