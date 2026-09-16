using ECommerceAPI.Enums;
namespace ECommerceAPI.Entities
{
    /// <summary>
    /// The NotificationQueueItem entity stores Email and SMS notifications that need to be processed by the application. 
    /// It maintains the delivery channel, processing status, retry count, next retry time, processed time, and failure information.
    /// </summary>

    public sealed class NotificationQueueItem : AuditableEntity
    {
        public long Id { get; set; }
        public NotificationChannel NotificationChannelId { get; set; }
        public NotificationStatus NotificationStatusId { get; set; } = ECommerceAPI.Enums.NotificationStatus.Pending;
        public string Recipient { get; set; } = string.Empty;
        public string? Subject { get; set; }
        public string Body { get; set; } = string.Empty;
        public int RetryCount { get; set; }
        public DateTime NextAttemptAtUtc { get; set; } = DateTime.UtcNow;
        public DateTime? ProcessingStartedAtUtc { get; set; }
        public DateTime? ProcessedAtUtc { get; set; }
        public string? LastError { get; set; }
        public NotificationChannelMaster NotificationChannel { get; set; } = null!;
        public NotificationStatusMaster NotificationStatus { get; set; } = null!;
    }
}
