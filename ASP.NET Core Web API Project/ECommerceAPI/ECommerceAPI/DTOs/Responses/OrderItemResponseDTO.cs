using ECommerceAPI.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace ECommerceAPI.DTOs.Responses
{
    /// <summary>
    /// Page: Order Details Page.
    /// It represents one Product.It included Product Name, SKU, Image, and Unit Price come from the Order snapshot rather than today's Product values. 
    /// </summary>
    public sealed class OrderItemResponseDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductSku { get; set; } = string.Empty;
        public string ProductImageUrl { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal LineTotal { get; set; }
    }
}
