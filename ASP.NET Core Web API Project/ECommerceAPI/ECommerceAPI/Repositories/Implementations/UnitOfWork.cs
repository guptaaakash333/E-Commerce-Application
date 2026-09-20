using Azure;
using ECommerceAPI.Data;
using ECommerceAPI.Entities;
using ECommerceAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Storage;
using Org.BouncyCastle.Utilities.Collections;
using System.Collections;
using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ECommerceAPI.Repositories.Implementations
{
    /// <summary>
    /// Why Do We Need a Database Transaction During Order Placement?
    /// Order Placement performs several related database operations.
    /// For example:
    /// -Create Order.
    /// -Create Order Items.
    /// -Create Payment Transaction.
    /// -Update Payment Status.
    /// -Update Order Status.
    /// -Add Order Status History. 
    /// -Reduce Product Stock when required.
    /// -Clear Shopping Cart when required.
    /// -Queue Email and SMS notifications.

    /// If one critical database operation fails halfway through, we do not want only part of the Order to be saved.
    /// For example, we should avoid a situation where:
    /// Order was created,
    /// Product Stock was reduced, but Payment Transaction could not be stored.
    /// A database transaction allows all related changes to succeed or fail together.
    /// </summary>


    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly ECommerceDbContext _context;

        // Holds the currently active database transaction.
        private IDbContextTransaction? _transaction;

        public UnitOfWork(ECommerceDbContext context)
        {
            _context = context;
        }

        // Saves all pending changes in the DbContext to the database.
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        // Starts a new database transaction if one is not already active.
        public async Task BeginTransactionAsync()
        {
            // Do not start another transaction if one is already active.
            if (_transaction != null)
            {
                return;
            }

            // Starts a new database transaction.
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        // Commits the current transaction and releases its resources.
        public async Task CommitTransactionAsync()
        {
            // Nothing to commit if there is no active transaction.
            if (_transaction == null)
            {
                return;
            }

            // Permanently saves all operations performed within the transaction.
            await _transaction.CommitAsync();

            // Releases the resources used by the transaction.
            await _transaction.DisposeAsync();

            // Clears the transaction reference because it is no longer active.
            _transaction = null;
        }

        // Rolls back the current transaction and releases its resources.
        public async Task RollbackTransactionAsync()
        {
            // Nothing to roll back if there is no active transaction.
            if (_transaction == null)
            {
                return;
            }

            // Cancels all database operations performed within the transaction.
            await _transaction.RollbackAsync();

            // Releases the resources used by the transaction.
            await _transaction.DisposeAsync();

            // Clears the transaction reference because it is no longer active.
            _transaction = null;
        }

        // Releases the active transaction when the Unit of Work is disposed.
        public async ValueTask DisposeAsync()
        {
            // Dispose the transaction only if one is still active.
            if (_transaction != null)
            {
                await _transaction.DisposeAsync();

                _transaction = null;
            }
        }
    }





}
