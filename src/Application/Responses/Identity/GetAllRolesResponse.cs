using System.Collections.Generic;

namespace BlazorHero.TraderWebApp.Application.Responses.Identity
{
    public class GetAllRolesResponse
    {
        public IEnumerable<RoleResponse> Roles { get; set; }
    }
}