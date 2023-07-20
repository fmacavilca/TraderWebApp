using System.Text.Json;
using BlazorHero.TraderWebApp.Application.Interfaces.Serialization.Options;

namespace BlazorHero.TraderWebApp.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}