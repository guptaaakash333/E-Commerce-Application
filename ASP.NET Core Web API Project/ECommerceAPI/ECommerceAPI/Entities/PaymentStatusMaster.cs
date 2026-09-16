using ECommerceAPI.Enums;
namespace ECommerceAPI.Entities
{
    /// <summary>
    /// The PaymentStatusMaster entity stores the payment status master data in the database. 
    /// Its Id corresponds to the strongly typed PaymentStatus enum used by the application.
    /// Initial Data for PaymentStatusMaster
    /// We will initially store the following payment statuses:
    /// //1 - Pending
    /// //2 - Paid
    /// //3 - Failed
    /// //4 - Refunded
    /// </summary>


    public sealed class PaymentStatusMaster : AuditableEntity
    {
        public PaymentStatus Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
        public int DisplayOrder { get; set; }
    }
}
