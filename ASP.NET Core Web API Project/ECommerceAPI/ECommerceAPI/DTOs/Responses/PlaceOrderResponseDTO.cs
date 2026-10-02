using ECommerceAPI.Entities;
using System.Numerics;
using static System.Net.WebRequestMethods;

namespace ECommerceAPI.DTOs.Responses
{
    /// <summary>
    /// Page: Order Result / Order Success / Pending / Failed Page.
    /// After an Order attempt, the client needs to know whether it was:
    /// - Successful
    /// - Pending
    /// - Failed
    ///
    /// The PlaceOrderResponseDTO represents the result returned after attempting to place an Order.
    /// </summary>
    
    public sealed class PlaceOrderResponseDTO
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; } = string.Empty;
        public string OrderStatus { get; set; } = string.Empty;
        public string PaymentStatus { get; set; } = string.Empty;
        public decimal GrandTotal { get; set; }
        public string Currency { get; set; } = "INR";
        public string? FailureMessage { get; set; }
    }
}
