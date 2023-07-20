using BlazorHero.TraderWebApp.Application.Interfaces.Services;
using System;

namespace BlazorHero.TraderWebApp.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}