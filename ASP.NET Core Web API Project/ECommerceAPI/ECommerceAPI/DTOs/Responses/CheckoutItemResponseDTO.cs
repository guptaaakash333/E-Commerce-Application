using ECommerceAPI.Entities;

namespace ECommerceAPI.DTOs.Responses
{
    /// <summary>
    /// Page: Checkout Page
    /// It represents one Product displayed in the final Order summary.
    /// </summary>

    public sealed class CheckoutItemResponseDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductImageUrl { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal LineTotal { get; set; }
    }
}
