using ECommerceAPI.Entities;
using Newtonsoft.Json.Linq;
using System.Runtime.Intrinsics.X86;
using static Twilio.Rest.Content.V1.ContentResource;

namespace ECommerceAPI.Enums
{
    /// <summary>
    /// The NotificationChannel enum specifies how a notification should be delivered to the customer. 
    /// The application currently supports Email and SMS notifications.
    /// </summary>
    /// 

    public enum NotificationChannel
    {
        Email = 1,
        Sms = 2
    }
}
