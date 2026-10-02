using Microsoft.VisualBasic;

namespace ECommerceAPI.DTOs.Responses
{
    /// <summary>
    /// Page: Order Details Page.
    /// It displays Payment attempt information such as Payment Method, Payment Status, Provider Transaction Id, Amount, Masked Instrument, Failure Reason, and completion time
    /// </summary>

    public sealed class PaymentTransactionResponseDTO
    {
        public int Id { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public string PaymentStatus { get; set; } = string.Empty;
        public string Provider { get; set; } = string.Empty;
        public string? ProviderTransactionId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; } = "INR";
        public string? MaskedInstrument { get; set; }
        public string? FailureReason { get; set; }
        public DateTime? CompletedAtUtc { get; set; }
        public DateTime CreatedAtUtc { get; set; }
    }

    /// <summary>
    /// Note:
    /// Only safe, masked payment information is returned. 
    /// The application does not store sensitive information such as full Card Numbers, CVV, UPI PIN, Banking Password, or OTP. 
    /// </summary>
}
