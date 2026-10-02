using ECommerceAPI.Entities;
using Microsoft.VisualBasic;

namespace ECommerceAPI.DTOs.Responses
{
    /// <summary>
    /// Used by: Category Listing and Product Details.
    /// The CategoryResponseDTO represents Product Category information.
    /// </summary>

    public sealed class CategoryResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
