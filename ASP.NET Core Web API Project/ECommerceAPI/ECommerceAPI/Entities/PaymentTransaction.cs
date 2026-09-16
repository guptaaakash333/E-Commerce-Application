using ECommerceAPI.Enums;
namespace ECommerceAPI.Entities
{
    /// <summary>
    /// The PaymentTransaction entity stores individual payment attempts associated with an order. 
    /// This is useful for the Payment Simulator because an order may have one or more payment attempts 
    /// with Pending, Paid, Failed, or Refunded statuses.
    /// </summary>
    /// 

    public sealed class PaymentTransaction : AuditableEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public PaymentMethod PaymentMethodId { get; set; }
        public PaymentStatus PaymentStatusId { get; set; } = ECommerceAPI.Enums.PaymentStatus.Pending;
        public string Provider { get; set; } = string.Empty;
        public string? ProviderTransactionId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; } = "INR";
        public string? MaskedInstrument { get; set; }
        public string? FailureReason { get; set; }
        public DateTime? CompletedAtUtc { get; set; }
        public byte[] RowVersion { get; set; } = Array.Empty<byte>();

        public Order Order { get; set; } = null!;
        public PaymentMethodMaster PaymentMethod { get; set; } = null!;
        public PaymentStatusMaster PaymentStatus { get; set; } = null!;
    }
}
