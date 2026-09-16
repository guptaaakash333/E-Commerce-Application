namespace ECommerceAPI.Models
{
    /// <summary>
    /// The JwtTokenResult class represents the result produced by the JWT token-generation service. 
    /// It contains the generated access token and the time at which the access token expires.
    /// </summary>


    public sealed class JwtTokenResult
    {
        public string AccessToken { get; set; } = string.Empty;
        public DateTime ExpiresAtUtc { get; set; }
    }
}
