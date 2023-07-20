using BlazorHero.TraderWebApp.Application.Requests;

namespace BlazorHero.TraderWebApp.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}