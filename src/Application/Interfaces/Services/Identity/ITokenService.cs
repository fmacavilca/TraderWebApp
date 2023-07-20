using BlazorHero.TraderWebApp.Application.Interfaces.Common;
using BlazorHero.TraderWebApp.Application.Requests.Identity;
using BlazorHero.TraderWebApp.Application.Responses.Identity;
using BlazorHero.TraderWebApp.Shared.Wrapper;
using System.Threading.Tasks;

namespace BlazorHero.TraderWebApp.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}