using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorHero.TraderWebApp.Application.Features.DocumentTypes.Commands.AddEdit;
using BlazorHero.TraderWebApp.Application.Features.DocumentTypes.Queries.GetAll;
using BlazorHero.TraderWebApp.Shared.Wrapper;

namespace BlazorHero.TraderWebApp.Client.Infrastructure.Managers.Misc.DocumentType
{
    public interface IDocumentTypeManager : IManager
    {
        Task<IResult<List<GetAllDocumentTypesResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditDocumentTypeCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}