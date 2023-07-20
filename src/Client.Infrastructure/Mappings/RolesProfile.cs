using AutoMapper;
using BlazorHero.TraderWebApp.Application.Requests.Identity;
using BlazorHero.TraderWebApp.Application.Responses.Identity;

namespace BlazorHero.TraderWebApp.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}