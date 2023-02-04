using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Data
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<Movie, MovieDto>();
            CreateMap<CustomerDto, Customer>().ForMember(m => m.Id, opt => opt.Ignore());
            CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());
        }

    }
}
