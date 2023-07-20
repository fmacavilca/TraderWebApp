using BlazorHero.TraderWebApp.Application.Requests.Identity;
using BlazorHero.TraderWebApp.Application.Responses.Identity;
using BlazorHero.TraderWebApp.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorHero.TraderWebApp.Client.Infrastructure.Managers.Identity.Roles
{
    public interface IRoleManager : IManager
    {
        Task<IResult<List<RoleResponse>>> GetRolesAsync();

        Task<IResult<string>> SaveAsync(RoleRequest role);

        Task<IResult<string>> DeleteAsync(string id);

        Task<IResult<PermissionResponse>> GetPermissionsAsync(string roleId);

        Task<IResult<string>> UpdatePermissionsAsync(PermissionRequest request);
    }
}