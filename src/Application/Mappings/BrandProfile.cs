using AutoMapper;
using BlazorHero.TraderWebApp.Application.Features.Brands.Commands.AddEdit;
using BlazorHero.TraderWebApp.Application.Features.Brands.Queries.GetAll;
using BlazorHero.TraderWebApp.Application.Features.Brands.Queries.GetById;
using BlazorHero.TraderWebApp.Domain.Entities.Catalog;

namespace BlazorHero.TraderWebApp.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}