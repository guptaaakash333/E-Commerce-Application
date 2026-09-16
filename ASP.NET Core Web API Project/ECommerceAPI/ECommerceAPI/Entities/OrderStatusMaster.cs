using ECommerceAPI.Enums;
namespace ECommerceAPI.Entities
{
    /// <summary>
    /// The OrderStatusMaster entity stores the available order statuses in the database.
    /// It provides descriptive information for the strongly typed OrderStatus values used throughout the application.
    /// Initial Data for OrderStatusMaster
    /// We will initially store the following order statuses:
    ///1 - Pending
    ///2 - Confirmed
    ///3 - Processing
    ///4 - Shipped
    ///5 - Delivered
    ///6 - Cancelled
    ///7 - Payment Failed
    /// </summary>

    public sealed class OrderStatusMaster : AuditableEntity
    {
        public OrderStatus Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
        public int DisplayOrder { get; set; }
    }
}
