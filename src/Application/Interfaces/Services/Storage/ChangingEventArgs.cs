using System.Diagnostics.CodeAnalysis;

namespace BlazorHero.TraderWebApp.Application.Interfaces.Services.Storage
{
    [ExcludeFromCodeCoverage]
    public class ChangingEventArgs : ChangedEventArgs
    {
        public bool Cancel { get; set; }
    }
}