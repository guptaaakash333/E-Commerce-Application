using ECommerceAPI.Enums;
namespace ECommerceAPI.Models
{
    /// <summary>
    /// The PaymentResult class represents the internal result returned by the payment processing service or Payment Simulator. 
    /// It contains the payment status, provider information, transaction identifier, masked payment information, and any failure reason.
    /// </summary>

    public sealed class PaymentResult
    {
        public PaymentStatus Status { get; set; }
        public string Provider { get; set; } = string.Empty;
        public string? ProviderTransactionId { get; set; }
        public string? MaskedInstrument { get; set; }
        public string? FailureReason { get; set; }
    }
}
