using ECommerceAPI.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Azure.Core.HttpHeader;
namespace ECommerceAPI.Repositories.Interfaces
{
    /// <summary>
    /// The Shopping Cart supports:
    /// - View Cart
    /// - Add Product
    /// - Increase Quantity
    /// - Decrease Quantity
    /// - Remove Product
    /// - Clear Cart
    ///The Cart entity contains a collection of Cart Items, and every Cart Item refers to a Product.
    /// </summary>

    public interface ICartRepository
    {
        // Gets a customer's cart with its items and product details
        // for read-only operations.
        Task<Cart?> GetByCustomerIdAsync(int customerId);

        // Gets a customer's cart with its items and product details
        // with tracking enabled for update operations.
        Task<Cart?> GetByCustomerIdForUpdateAsync(int customerId);

        // Adds a new cart to the database context.
        Task AddAsync(Cart cart);

        // Removes a specific item from the cart.
        void RemoveItem(CartItem cartItem);

        // Removes all specified items from the cart.
        void ClearItems(IEnumerable<CartItem> cartItems);
    }
}
