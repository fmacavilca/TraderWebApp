using BlazorHero.TraderWebApp.Application.Models.Chat;
using BlazorHero.TraderWebApp.Application.Responses.Identity;
using BlazorHero.TraderWebApp.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorHero.TraderWebApp.Application.Interfaces.Chat;

namespace BlazorHero.TraderWebApp.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}