﻿using BlazorHero.TraderWebApp.Application.Features.Brands.Queries.GetAll;
using BlazorHero.TraderWebApp.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorHero.TraderWebApp.Application.Features.Brands.Commands.AddEdit;
using BlazorHero.TraderWebApp.Application.Features.Brands.Commands.Import;

namespace BlazorHero.TraderWebApp.Client.Infrastructure.Managers.Catalog.Brand
{
    public interface IBrandManager : IManager
    {
        Task<IResult<List<GetAllBrandsResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditBrandCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");

        Task<IResult<int>> ImportAsync(ImportBrandsCommand request);
    }
}