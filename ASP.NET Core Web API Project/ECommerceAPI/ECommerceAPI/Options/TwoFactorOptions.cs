namespace ECommerceAPI.Options
{
    /// <summary>
    /// The TwoFactorOptions class contains configuration values used during Two-Factor Authentication. 
    /// It specifies how long a login verification code remains valid and how many incorrect verification attempts are permitted.
    /// </summary>


    public sealed class TwoFactorOptions
    {
        public const string SectionName = "TwoFactor";
        public int CodeExpiryMinutes { get; set; } = 5;
        public int MaxFailedAttempts { get; set; } = 5;
    }
}
