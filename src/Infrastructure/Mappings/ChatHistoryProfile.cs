using AutoMapper;
using BlazorHero.TraderWebApp.Application.Interfaces.Chat;
using BlazorHero.TraderWebApp.Application.Models.Chat;
using BlazorHero.TraderWebApp.Infrastructure.Models.Identity;

namespace BlazorHero.TraderWebApp.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}