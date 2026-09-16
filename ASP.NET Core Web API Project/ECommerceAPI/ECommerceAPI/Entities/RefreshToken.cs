namespace ECommerceAPI.Entities
{
    /// <summary>
    /// The RefreshToken entity stores refresh tokens associated with a customer. 
    /// Refresh tokens should be stored in the database because this allows us to validate them, revoke them during logout, 
    /// expire them, and maintain multiple authenticated sessions if required. 
    /// For security, the plain-text refresh token should not be stored in the database. 
    /// Only its hash should be persisted.
    /// </summary>


    public sealed class RefreshToken : AuditableEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string TokenHash { get; set; } = string.Empty;
        public DateTime ExpiresAtUtc { get; set; }
        public DateTime? RevokedAtUtc { get; set; }
        public byte[] RowVersion { get; set; } = Array.Empty<byte>();

        public Customer Customer { get; set; } = null!;
    }
}
