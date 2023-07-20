using AutoMapper;
using BlazorHero.TraderWebApp.Application.Features.Products.Commands.AddEdit;
using BlazorHero.TraderWebApp.Domain.Entities.Catalog;

namespace BlazorHero.TraderWebApp.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}