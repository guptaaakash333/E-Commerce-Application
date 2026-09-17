using ECommerceAPI.Entities;
using Org.BouncyCastle.Cms;
using System.Diagnostics;
using Twilio.TwiML.Messaging;

namespace ECommerceAPI.Repositories.Interfaces
{
    /// <summary>
    /// The Notification Queue stores Email and SMS notifications that need to be processed.
    /// The entity contains:
    /// - Notification Channel
    /// - Notification Status
    /// - Recipient
    /// - Subject
    /// - Body
    /// - Retry Count
    /// - Next Attempt Time
    /// - Processing Started Time
    /// - Processed Time
    /// - Last Error
    /// The background Notification Processor must atomically claim Notifications that are ready to be processed 
    /// so that multiple application instances do not process the same Notification simultaneously.
    /// </summary>

    public interface INotificationRepository
    {
        // Adds a single notification to the notification queue.
        Task AddAsync(NotificationQueueItem notification);

        // Adds multiple notifications to the notification queue at once.
        Task AddRangeAsync(IEnumerable<NotificationQueueItem> notifications);

        // Finds and safely claims notifications that are ready to be processed.
        Task<List<NotificationQueueItem>> ClaimReadyForProcessingAsync(int batchSize, int maxRetries, DateTime utcNow,
            DateTime staleProcessingBeforeUtc);
    }
}
