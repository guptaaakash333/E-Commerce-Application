using ECommerceAPI.Data;
using ECommerceAPI.Entities;
using ECommerceAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Repositories.Implementations
{
    /// <summary>
    /// Note: The AddAsync method only adds the customer to the DbContext. 
    /// It does not save the customer to the database until SaveChangesAsync() is called elsewhere, 
    /// such as from a Unit of Work, service, or DbContext.
    /// </summary>

    public sealed class CustomerRepository : ICustomerRepository
    {
        private readonly ECommerceDbContext _context;
        public CustomerRepository(ECommerceDbContext context)
        {
            _context = context;
        }

        // Gets a customer by ID without tracking because the data is only being read.
        public async Task<Customer?> GetByIdAsync(int customerId)
        {
            return await _context.Customers
                .AsNoTracking()   // No tracking because we are only reading the data, not updating it.
                .FirstOrDefaultAsync(x => x.Id == customerId);    // Returns null if no customer is found with the given ID.
        }

        // Gets a customer by ID with tracking enabled so that it can be updated.
        public async Task<Customer?> GetByIdForUpdateAsync(int customerId)
        {
            return await _context.Customers
                .FirstOrDefaultAsync(x => x.Id == customerId);
        }

        // Gets a customer by email address without tracking the entity.
        public async Task<Customer?> GetByEmailAsync(string email)
        {
            return await _context.Customers
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Email == email);
        }

        // Gets a customer by phone number without tracking the entity.
        public async Task<Customer?> GetByPhoneNumberAsync(string phoneNumber)
        {
            return await _context.Customers
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.PhoneNumber == phoneNumber);
        }

        // Checks whether the given email address is already registered.
        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _context.Customers
                .AnyAsync(x => x.Email == email);
        }

        // Checks whether the given phone number is already registered.
        public async Task<bool> PhoneNumberExistsAsync(string phoneNumber)
        {
            return await _context.Customers
                .AnyAsync(x => x.PhoneNumber == phoneNumber);
        }

        // Adds a new customer to the DbContext for insertion into the database.
        public async Task AddAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
        }
    }
}
