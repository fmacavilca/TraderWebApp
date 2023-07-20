using AutoMapper;
using BlazorHero.TraderWebApp.Application.Features.DocumentTypes.Commands.AddEdit;
using BlazorHero.TraderWebApp.Application.Features.DocumentTypes.Queries.GetAll;
using BlazorHero.TraderWebApp.Application.Features.DocumentTypes.Queries.GetById;
using BlazorHero.TraderWebApp.Domain.Entities.Misc;

namespace BlazorHero.TraderWebApp.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}