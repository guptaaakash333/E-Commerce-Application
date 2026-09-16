namespace ECommerceAPI.Options
{
    /// <summary>
    /// The EmailOptions class contains the configuration required for sending Email notifications using the Gmail SMTP server. 
    /// The application can use these settings for registration Emails, login verification codes, and order-related notifications.
    /// </summary>


    public sealed class EmailOptions
    {
        public const string SectionName = "Email";
        public string Host { get; set; } = "smtp.gmail.com";
        public int Port { get; set; } = 587;
        public string SenderName { get; set; } = "E-Commerce Application";
        public string FromEmail { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string AppPassword { get; set; } = string.Empty;
    }
}
