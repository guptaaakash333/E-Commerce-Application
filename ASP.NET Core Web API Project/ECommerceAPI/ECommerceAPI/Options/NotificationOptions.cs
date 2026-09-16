namespace ECommerceAPI.Options
{
    /// <summary>
    /// The NotificationOptions class contains settings used while processing queued Email and SMS notifications. 
    /// It defines how many notifications should be processed in one batch, how frequently the processor checks for pending messages, 
    /// and how many retries are allowed for failed notifications.
    /// </summary>


    public sealed class NotificationOptions
    {
        public const string SectionName = "Notifications";
        public int BatchSize { get; set; } = 20;
        public int PollingSeconds { get; set; } = 5;
        public int MaxRetries { get; set; } = 3;
    }
}
