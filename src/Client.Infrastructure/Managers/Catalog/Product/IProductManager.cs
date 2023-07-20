using BlazorHero.TraderWebApp.Application.Features.Products.Commands.AddEdit;
using BlazorHero.TraderWebApp.Application.Features.Products.Queries.GetAllPaged;
using BlazorHero.TraderWebApp.Application.Requests.Catalog;
using BlazorHero.TraderWebApp.Shared.Wrapper;
using System.Threading.Tasks;

namespace BlazorHero.TraderWebApp.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}