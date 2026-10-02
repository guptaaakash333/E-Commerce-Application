using ECommerceAPI.Entities;
using Microsoft.VisualBasic;
using System.Collections;
using System.Reflection;

namespace ECommerceAPI.DTOs.Responses
{
    /// <summary>
    /// Page: Product Listing Page
    /// It contains Product Name, SKU, Price, Image, Category, and stock information.
    /// This DTO contains the information required to display a Product on the Product Listing page.
    /// </summary>

    public sealed class ProductListItemResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Sku { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public bool IsInStock { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }
}
