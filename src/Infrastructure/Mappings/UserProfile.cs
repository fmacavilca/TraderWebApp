using AutoMapper;
using BlazorHero.TraderWebApp.Infrastructure.Models.Identity;
using BlazorHero.TraderWebApp.Application.Responses.Identity;

namespace BlazorHero.TraderWebApp.Infrastructure.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, BlazorHeroUser>().ReverseMap();
            CreateMap<ChatUserResponse, BlazorHeroUser>().ReverseMap()
                .ForMember(dest => dest.EmailAddress, source => source.MapFrom(source => source.Email)); //Specific Mapping
        }
    }
}