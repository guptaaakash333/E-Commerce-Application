namespace ECommerceAPI.Models
{
    /// <summary>
    /// The RefreshTokenResult class is an internal application model used while generating a refresh token. 
    /// It contains the plain-text token returned to the client, the hashed token stored in the database, 
    /// and the expiration time of the refresh token.
    /// </summary>


    public sealed class RefreshTokenResult
    {
        public string PlainTextToken { get; set; } = string.Empty;
        public string TokenHash { get; set; } = string.Empty;
        public DateTime ExpiresAtUtc { get; set; }
    }
}
