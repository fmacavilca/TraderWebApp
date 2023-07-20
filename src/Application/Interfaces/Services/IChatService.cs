using BlazorHero.TraderWebApp.Application.Responses.Identity;
using BlazorHero.TraderWebApp.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorHero.TraderWebApp.Application.Interfaces.Chat;
using BlazorHero.TraderWebApp.Application.Models.Chat;

namespace BlazorHero.TraderWebApp.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}