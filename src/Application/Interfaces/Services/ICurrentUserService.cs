using BlazorHero.TraderWebApp.Application.Interfaces.Common;

namespace BlazorHero.TraderWebApp.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}