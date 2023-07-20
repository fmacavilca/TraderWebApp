using BlazorHero.TraderWebApp.Shared.Wrapper;
using System.Threading.Tasks;
using BlazorHero.TraderWebApp.Application.Features.Dashboards.Queries.GetData;

namespace BlazorHero.TraderWebApp.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}