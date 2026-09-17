using ECommerceAPI.Entities;

namespace ECommerceAPI.Repositories.Interfaces
{
    /// <summary>
    /// The Customer Address feature supports multiple addresses and default Shipping and Billing addresses.
    /// 
    /// Note: Please note that both Address Id and Customer Id are used while retrieving an Address. 
    ///       This is important because one authenticated customer must not be able to access another customer's address.
    /// </summary>


    public interface ICustomerAddressRepository
    {
        // Gets all addresses of a customer for read-only operations.
        Task<List<CustomerAddress>> GetByCustomerIdAsync(int customerId);

        // Gets all addresses of a customer with tracking enabled for update operations.
        Task<List<CustomerAddress>> GetByCustomerIdForUpdateAsync(int customerId);

        // Gets a specific customer address by address ID and customer ID for read-only operations.
        Task<CustomerAddress?> GetByIdAsync(int addressId, int customerId);

        // Gets a specific customer address with tracking enabled so that it can be updated.
        Task<CustomerAddress?> GetByIdForUpdateAsync(int addressId, int customerId);

        // Adds a new customer address to the database context.
        Task AddAsync(CustomerAddress address);

        // Removes the specified customer address from the database context.
        void Remove(CustomerAddress address);
    }
}
