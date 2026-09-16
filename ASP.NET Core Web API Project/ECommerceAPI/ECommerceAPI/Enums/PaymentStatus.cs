namespace ECommerceAPI.Enums
{
    /// <summary>
    /// The PaymentStatus enum represents the current state of a payment transaction. 
    /// It is used while processing payments and maintaining payment history for an order.
    /// </summary>
    /// 

    public enum PaymentStatus
    {
        Pending = 1,
        Paid = 2,
        Failed = 3,
        Refunded = 4
    }
}
