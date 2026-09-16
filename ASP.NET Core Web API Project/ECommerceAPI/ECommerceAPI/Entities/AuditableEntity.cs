namespace ECommerceAPI.Entities
{
    /// <summary>
    /// The AuditableEntity class is the base class for entities that require audit information. 
    /// It stores when a record was created, who created it, when it was last updated, and who updated it. 
    /// Other entities inherit from this class so that the audit properties do not need to be repeated in every entity.
    /// </summary>

    public abstract class AuditableEntity
    {
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAtUtc { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
