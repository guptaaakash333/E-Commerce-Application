using ECommerceAPI.Entities;
using Microsoft.AspNetCore.Identity;

namespace ECommerceAPI.Helpers
{
    /// <summary>
    /// The PasswordHelper contains reusable methods for securely hashing and verifying customer passwords.
    /// </summary>
    public static class PasswordHelper
    {
        /// <summary>
        /// Converts the customer's plain-text password into a secure hash
        /// before storing it in the database.
        /// Example:
        /// Plain Password: MyPass@123
        /// Stored Hash: AQAAAAIAAYagAAAAE...
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="password"></param>
        /// <returns></returns>        
        public static string HashPassword(Customer customer, string password)
        {
            // Create ASP.NET Core Identity's password hasher
            // for the Customer entity type.
            var passwordHasher = new PasswordHasher<Customer>();

            // Hash the plain-text password and return the generated secure password hash.
            // The Customer object is passed because PasswordHasher<TUser> is designed to receive
            // the associated user object as context.
            return passwordHasher.HashPassword(customer, password);
        }

        /// <summary>
        /// Verifies whether the plain-text password entered by the user
        /// matches the password hash stored in the database.
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="passwordHash"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool VerifyPassword(Customer customer, string passwordHash, string password)
        {
            // Create the same PasswordHasher<Customer> that is used for hashing passwords.
            var passwordHasher = new PasswordHasher<Customer>();

            // Compare the entered password with the stored password hash.
            var result = passwordHasher.VerifyHashedPassword(customer, passwordHash, password);

            // VerifyHashedPassword can return:
            // Failed
            // Success
            return result != PasswordVerificationResult.Failed;
        }
    }
}
