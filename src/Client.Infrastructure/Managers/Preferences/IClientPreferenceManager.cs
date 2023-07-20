using BlazorHero.TraderWebApp.Shared.Managers;
using MudBlazor;
using System.Threading.Tasks;

namespace BlazorHero.TraderWebApp.Client.Infrastructure.Managers.Preferences
{
    public interface IClientPreferenceManager : IPreferenceManager
    {
        Task<MudTheme> GetCurrentThemeAsync();

        Task<bool> ToggleDarkModeAsync();
    }
}