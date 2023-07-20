using System.Linq;
using BlazorHero.TraderWebApp.Shared.Constants.Localization;
using BlazorHero.TraderWebApp.Shared.Settings;

namespace BlazorHero.TraderWebApp.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}