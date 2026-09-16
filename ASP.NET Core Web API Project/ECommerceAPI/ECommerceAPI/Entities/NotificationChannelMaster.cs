using ECommerceAPI.Enums;
namespace ECommerceAPI.Entities
{
    /// <summary>
    /// The NotificationChannelMaster entity stores the notification channels supported by the application. 
    /// Initially, the application will store Email and SMS as notification channels.
    /// Initial Data for NotificationChannelMaster
    ///We will initially store the following notification channels:
    /// //1 - Email
    /// //2 - SMS
    /// </summary>

    public sealed class NotificationChannelMaster : AuditableEntity
    {
        public NotificationChannel Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public int DisplayOrder { get; set; }
    }
}
