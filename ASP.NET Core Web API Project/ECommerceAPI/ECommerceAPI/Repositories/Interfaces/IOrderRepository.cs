using ECommerceAPI.Entities;
using ECommerceAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Org.BouncyCastle.Utilities.Collections;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ECommerceAPI.Repositories.Interfaces
{
    /// <summary>
    /// The Order repository is one of the most important repositories in our application. The Order entity contains pricing, Shipping and 
    /// Billing address snapshots, Payment Method, Payment Status, Order Status, Items, Payments, and Status Histories. 
    ///The Repository needs to support:
    /// - Create Order
    /// - Retrieve Order History
    /// - Retrieve Order Details
    /// - Retrieve an existing Order for update
    /// - Add Order Status History
    /// </summary>

    public interface IOrderRepository
    {
        // Adds a new order to the database context.
        Task AddAsync(Order order);

        // Gets a paginated list of orders placed by a specific customer.
        Task<PagedResult<Order>> GetCustomerOrdersAsync(int customerId, int pageNumber, int pageSize);

        // Gets complete details of a specific order belonging to a customer.
        Task<Order?> GetDetailsAsync(int orderId, int customerId);

        // Gets an order by ID with tracking enabled for update operations.
        Task<Order?> GetByIdForUpdateAsync(int orderId);

        // Adds a new order status change history record to the database context.
        Task AddStatusHistoryAsync(OrderStatusHistory orderStatusHistory);

        // Gets an order using the customer ID and unique checkout token.
        Task<Order?> GetByCheckoutTokenAsync(int customerId, Guid checkoutToken);
    }
}
