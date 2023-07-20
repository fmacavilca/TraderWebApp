using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorHero.TraderWebApp.Application.Interfaces.Common;
using BlazorHero.TraderWebApp.Application.Requests.Identity;
using BlazorHero.TraderWebApp.Application.Responses.Identity;
using BlazorHero.TraderWebApp.Shared.Wrapper;

namespace BlazorHero.TraderWebApp.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}