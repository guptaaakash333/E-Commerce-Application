using ECommerceAPI.Entities;
using ECommerceAPI.Models;
using System.Collections;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ECommerceAPI.Repositories.Interfaces
{
    /// <summary>
    /// The Product Listing page requires:
    /// - Search
    /// - Category filtering
    /// - Minimum price filtering
    /// - Maximum price filtering
    /// - In-stock filtering
    /// - Sorting
    /// - Paging
    /// We also need Product Details and tracked Products during Order Placement when product stock is updated.
    /// </summary>


    public interface IProductRepository
    {
        // Gets a paginated list of active products based on
        // search, filter, sorting, and paging criteria.
        Task<PagedResult<Product>> GetProductsAsync(string? searchTerm, int? categoryId, decimal? minPrice, decimal? maxPrice,
                                         bool inStockOnly, string? sortBy, string? sortDirection, int pageNumber, int pageSize);

        // Gets an active product by its unique product ID.
        Task<Product?> GetByIdAsync(int productId);

        // Gets all active product categories.
        Task<List<Category>> GetActiveCategoriesAsync();

        // Gets active products by their IDs with tracking enabled for update operations.
        Task<List<Product>> GetProductsByIdsForUpdateAsync(List<int> productIds);
    }
}
