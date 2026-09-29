using System.ComponentModel.DataAnnotations;
using Twilio.Jwt.AccessToken;
namespace ECommerceAPI.DTOs.Requests
{
    /// <summary>
    /// Page: Logout Button; No Separate Logout Page
    /// Logout requires the Refresh Token associated with the current session so that it can be revoked.
    /// </summary>

    public sealed class LogoutRequestDTO
    {
        [Required(ErrorMessage = "Refresh Token is required.")]
        [StringLength(1000, ErrorMessage = "Refresh Token is invalid.")]
        public string RefreshToken { get; set; } = string.Empty;
    }
}
