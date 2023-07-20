using System.Collections.Generic;

namespace BlazorHero.TraderWebApp.Application.Responses.Identity
{
    public class GetAllUsersResponse
    {
        public IEnumerable<UserResponse> Users { get; set; }
    }
}