namespace ECommerceAPI.Enums
{
    /// <summary>
    /// The OrderStatus enum represents the current state of an order throughout its lifecycle. 
    /// A newly created order starts with Pending, and its status can later change to Confirmed, Processing, Shipped, Delivered, Cancelled,
    /// or PaymentFailed.
    /// </summary>

    public enum OrderStatus
    {
        Pending = 1,
        Confirmed = 2,
        Processing = 3,
        Shipped = 4,
        Delivered = 5,
        Cancelled = 6,
        PaymentFailed = 7
    }
}
