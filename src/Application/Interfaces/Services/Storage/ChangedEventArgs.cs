using System.Diagnostics.CodeAnalysis;

namespace BlazorHero.TraderWebApp.Application.Interfaces.Services.Storage
{
    [ExcludeFromCodeCoverage]
    public class ChangedEventArgs
    {
        public string Key { get; set; }
        public object OldValue { get; set; }
        public object NewValue { get; set; }
    }
}