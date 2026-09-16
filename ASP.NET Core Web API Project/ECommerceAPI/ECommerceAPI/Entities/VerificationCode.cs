using ECommerceAPI.Enums;
namespace ECommerceAPI.Entities
{
    /// <summary>
    /// The VerificationCode entity stores temporary verification codes used for Email Verification, Mobile Verification, 
    /// and Two-Factor Login Verification. 
    /// The actual verification code will not be stored as plain text. 
    /// Instead, its hash will be stored in the database. 
    /// Each generated code has an expiration time, tracks failed attempts, and can only be successfully used once.
    /// </summary>


    public sealed class VerificationCode : AuditableEntity
    {
        public long Id { get; set; }
        public int CustomerId { get; set; }
        public VerificationPurpose Purpose { get; set; }
        public string Identifier { get; set; } = string.Empty;
        public string CodeHash { get; set; } = string.Empty;
        public DateTime ExpiresAtUtc { get; set; }
        public int FailedAttempts { get; set; }
        public DateTime? UsedAtUtc { get; set; }
        public byte[] RowVersion { get; set; } = Array.Empty<byte>();
        public Customer Customer { get; set; } = null!;
    }

    ///<summary>
    ///Note: The RowVersion is useful because the same verification code must not be consumed successfully 
    ///by two concurrent requests from two API instances.
    ///</summary>


}
