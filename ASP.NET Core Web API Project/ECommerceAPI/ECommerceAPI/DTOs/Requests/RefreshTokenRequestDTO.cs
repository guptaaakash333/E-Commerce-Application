using System.ComponentModel.DataAnnotations;
namespace ECommerceAPI.DTOs.Requests
{
    /// <summary>
    /// Page: No Visible Page
    /// This is mainly used internally by the client application such as angular when the JWT Access Token expires.
    /// It sends the Refresh Token to the Web API so a new Access Token can be generated.
    /// </summary>

    public sealed class RefreshTokenRequestDTO
    {
        [Required(ErrorMessage = "Refresh Token is required.")]
        [StringLength(1000, ErrorMessage = "Refresh Token is invalid.")]
        public string RefreshToken { get; set; } = string.Empty;
    }
}
