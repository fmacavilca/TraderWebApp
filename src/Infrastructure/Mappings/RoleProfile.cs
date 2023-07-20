using AutoMapper;
using BlazorHero.TraderWebApp.Infrastructure.Models.Identity;
using BlazorHero.TraderWebApp.Application.Responses.Identity;

namespace BlazorHero.TraderWebApp.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}