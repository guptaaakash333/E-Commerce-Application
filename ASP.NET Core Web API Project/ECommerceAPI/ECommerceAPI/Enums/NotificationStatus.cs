namespace ECommerceAPI.Enums
{

    ///<summary>    
    ///The NotificationStatus enum represents the processing status of an Email or SMS notification. 
    ///It allows the application to track whether a notification is waiting to be sent, Processing, sent successfully, or failed.
    ///</summary>   


    public enum NotificationStatus
    {
        Pending = 1,
        Sent = 2,
        Failed = 3,
        Processing = 4

    }
}
