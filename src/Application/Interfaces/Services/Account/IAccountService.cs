using BlazorHero.TraderWebApp.Application.Interfaces.Common;
using BlazorHero.TraderWebApp.Application.Requests.Identity;
using BlazorHero.TraderWebApp.Shared.Wrapper;
using System.Threading.Tasks;

namespace BlazorHero.TraderWebApp.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}