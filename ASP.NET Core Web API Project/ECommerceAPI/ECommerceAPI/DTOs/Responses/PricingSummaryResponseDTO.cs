using ECommerceAPI.Entities;
using System.ComponentModel;

namespace ECommerceAPI.DTOs.Responses
{
    /// <summary>
    /// Page: Checkout Page and Order Details Page.
    /// The PricingSummaryResponseDTO contains the pricing information calculated during Checkout and Order Placement.
    /// </summary>
    
    public sealed class PricingSummaryResponseDTO
    {
        public decimal Subtotal { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal GrandTotal { get; set; }
        public string Currency { get; set; } = "INR";
    }
}
