using System;

namespace BlazorHero.TraderWebApp.Application.Interfaces.Services
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}