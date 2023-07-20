using BlazorHero.TraderWebApp.Application.Responses.Audit;
using BlazorHero.TraderWebApp.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorHero.TraderWebApp.Application.Interfaces.Services
{
    public interface IAuditService
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync(string userId);

        Task<IResult<string>> ExportToExcelAsync(string userId, string searchString = "", bool searchInOldValues = false, bool searchInNewValues = false);
    }
}