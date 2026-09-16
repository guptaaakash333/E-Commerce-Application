using Newtonsoft.Json.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace ECommerceAPI.Options
{
    /// <summary>
    /// Options/JwtOptions.cs
    /// The JwtOptions class represents JWT authentication settings loaded from application configuration.
    /// These values are used while generating and validating access tokens and refresh tokens.
    /// </summary>

    public sealed class JwtOptions
    {
        public const string SectionName = "Jwt";
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public int AccessTokenMinutes { get; set; } = 15;
        public int RefreshTokenDays { get; set; } = 7;
    }
}
