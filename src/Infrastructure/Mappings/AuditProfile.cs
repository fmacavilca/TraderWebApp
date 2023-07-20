using AutoMapper;
using BlazorHero.TraderWebApp.Infrastructure.Models.Audit;
using BlazorHero.TraderWebApp.Application.Responses.Audit;

namespace BlazorHero.TraderWebApp.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}