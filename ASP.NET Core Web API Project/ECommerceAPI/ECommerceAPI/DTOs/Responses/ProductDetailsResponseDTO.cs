using ECommerceAPI.Entities;

namespace ECommerceAPI.DTOs.Responses
{
    /// <summary>
    /// Page: Product Details Page
    /// It contains the complete Product information needed to be displayed in the Product details page.
    /// </summary>

    public sealed class ProductDetailsResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Sku { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public bool IsInStock { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public CategoryResponseDTO Category { get; set; } = null!;
    }
}
