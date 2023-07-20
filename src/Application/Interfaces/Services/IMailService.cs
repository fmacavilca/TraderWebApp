using BlazorHero.TraderWebApp.Application.Requests.Mail;
using System.Threading.Tasks;

namespace BlazorHero.TraderWebApp.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}