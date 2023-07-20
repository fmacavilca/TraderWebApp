using AutoMapper;
using BlazorHero.TraderWebApp.Application.Features.Documents.Commands.AddEdit;
using BlazorHero.TraderWebApp.Application.Features.Documents.Queries.GetById;
using BlazorHero.TraderWebApp.Domain.Entities.Misc;

namespace BlazorHero.TraderWebApp.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}