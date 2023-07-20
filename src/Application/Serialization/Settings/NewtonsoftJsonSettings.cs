
using BlazorHero.TraderWebApp.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace BlazorHero.TraderWebApp.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}