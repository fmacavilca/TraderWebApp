using BlazorHero.TraderWebApp.Application.Requests.Identity;
using BlazorHero.TraderWebApp.Shared.Wrapper;
using System.Threading.Tasks;

namespace BlazorHero.TraderWebApp.Client.Infrastructure.Managers.Identity.Account
{
    public interface IAccountManager : IManager
    {
        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model);

        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}