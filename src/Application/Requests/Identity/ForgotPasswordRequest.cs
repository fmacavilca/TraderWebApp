using System.ComponentModel.DataAnnotations;

namespace BlazorHero.TraderWebApp.Application.Requests.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}