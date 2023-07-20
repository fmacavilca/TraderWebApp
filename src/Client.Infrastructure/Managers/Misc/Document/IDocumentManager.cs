using BlazorHero.TraderWebApp.Application.Features.Documents.Commands.AddEdit;
using BlazorHero.TraderWebApp.Application.Features.Documents.Queries.GetAll;
using BlazorHero.TraderWebApp.Application.Requests.Documents;
using BlazorHero.TraderWebApp.Shared.Wrapper;
using System.Threading.Tasks;
using BlazorHero.TraderWebApp.Application.Features.Documents.Queries.GetById;

namespace BlazorHero.TraderWebApp.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}