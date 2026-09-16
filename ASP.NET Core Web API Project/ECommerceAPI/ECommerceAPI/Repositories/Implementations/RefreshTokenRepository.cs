using ECommerceAPI.Data;
using ECommerceAPI.Entities;
using ECommerceAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Repositories.Implementations
{
    public sealed class RefreshTokenRepository : IRefreshTokenRepository
    {
        private readonly ECommerceDbContext _context;
        public RefreshTokenRepository(ECommerceDbContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Gets a refresh token by matching the provided hashed token value.
        /// Note: Here, GetByTokenHashAsync() does not use AsNoTracking() because the retrieved refresh token may later be updated,
        /// for example to mark it as revoked or used.
        /// </summary>
        public async Task<RefreshToken?> GetByTokenHashAsync(string tokenHash)
        {
            return await _context.RefreshTokens
                .FirstOrDefaultAsync(x => x.TokenHash == tokenHash);
        }

        // Adds a new refresh token to the DbContext for insertion into the database.
        public async Task AddAsync(RefreshToken refreshToken)
        {
            await _context.RefreshTokens.AddAsync(refreshToken);
        }
    }
}
