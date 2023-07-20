using BlazorHero.TraderWebApp.Application.Models.Chat;
using BlazorHero.TraderWebApp.Application.Responses.Identity;
using BlazorHero.TraderWebApp.Client.Infrastructure.Extensions;
using BlazorHero.TraderWebApp.Shared.Wrapper;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorHero.TraderWebApp.Application.Interfaces.Chat;

namespace BlazorHero.TraderWebApp.Client.Infrastructure.Managers.Communication
{
    public class ChatManager : IChatManager
    {
        private readonly HttpClient _httpClient;

        public ChatManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId)
        {
            var response = await _httpClient.GetAsync(Routes.ChatEndpoint.GetChatHistory(cId));
            var data = await response.ToResult<IEnumerable<ChatHistoryResponse>>();
            return data;
        }

        public async Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync()
        {
            var response = await _httpClient.GetAsync(Routes.ChatEndpoint.GetAvailableUsers);
            var data = await response.ToResult<IEnumerable<ChatUserResponse>>();
            return data;
        }

        public async Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.ChatEndpoint.SaveMessage, chatHistory);
            var data = await response.ToResult();
            return data;
        }
    }
}