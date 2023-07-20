using BlazorHero.TraderWebApp.Application.Interfaces.Common;
using BlazorHero.TraderWebApp.Application.Requests.Identity;
using BlazorHero.TraderWebApp.Application.Responses.Identity;
using BlazorHero.TraderWebApp.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorHero.TraderWebApp.Application.Interfaces.Services.Identity
{
    public interface IRoleService : IService
    {
        Task<Result<List<RoleResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleResponse>> GetByIdAsync(string id);

        Task<Result<string>> SaveAsync(RoleRequest request);

        Task<Result<string>> DeleteAsync(string id);

        Task<Result<PermissionResponse>> GetAllPermissionsAsync(string roleId);

        Task<Result<string>> UpdatePermissionsAsync(PermissionRequest request);
    }
}