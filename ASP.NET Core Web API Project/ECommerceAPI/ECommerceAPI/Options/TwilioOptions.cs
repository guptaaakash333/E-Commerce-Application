namespace ECommerceAPI.Options
{
    /// <summary>
    /// The TwilioOptions class contains configuration settings required to send SMS notifications using Twilio. 
    /// These values include the Twilio Account SID, authentication token, and sender phone number.
    /// </summary>

    public sealed class TwilioOptions
    {
        public const string SectionName = "Twilio";
        public string AccountSid { get; set; } = string.Empty;
        public string AuthToken { get; set; } = string.Empty;
        public string FromPhoneNumber { get; set; } = string.Empty;
    }
}
