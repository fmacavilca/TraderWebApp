using BlazorHero.TraderWebApp.Shared.Settings;
using System.Threading.Tasks;
using BlazorHero.TraderWebApp.Shared.Wrapper;

namespace BlazorHero.TraderWebApp.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}