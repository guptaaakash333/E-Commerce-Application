using System.ComponentModel;
using Twilio.Jwt.AccessToken;

namespace ECommerceAPI.DTOs.Responses
{
    /// <summary>
    /// Used By: Login, Successful 2FA Login Verification, and Refresh Token operation
    /// The TokenResponseDTO contains the newly generated Access Token and Refresh Token together with their expiration times.
    /// During Refresh Token processing, the existing Refresh Token will be revoked and a new Access Token and Refresh Token will be generated.
    /// </summary>
    public sealed class TokenResponseDTO
    {
        public string AccessToken { get; set; } = string.Empty;
        public DateTime AccessTokenExpiresAtUtc { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime RefreshTokenExpiresAtUtc { get; set; }
    }
}
