using ECommerceAPI.Entities;

namespace ECommerceAPI.DTOs.Responses
{
    /// <summary>
    /// Page: My Orders / Order History Page.
    /// The OrderListItemResponseDTO represents one Order displayed on the Customer's Order History page.
    /// </summary>

    public sealed class OrderListItemResponseDTO
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; } = string.Empty;
        public DateTime OrderDateUtc { get; set; }
        public int TotalItems { get; set; }
        public decimal GrandTotal { get; set; }
        public string Currency { get; set; } = "INR";
        public string PaymentMethod { get; set; } = string.Empty;
        public string PaymentStatus { get; set; } = string.Empty;
        public string OrderStatus { get; set; } = string.Empty;
    }
}
