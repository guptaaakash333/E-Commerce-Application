using ECommerceAPI.Enums;
namespace ECommerceAPI.Entities
{
    /// <summary>
    /// The OrderStatusHistory entity maintains the complete status-change history of an order. 
    /// Whenever the order status changes, a new record is created containing the previous status, the new status, 
    /// the time of the change, and optional remarks.
    /// </summary>

    public sealed class OrderStatusHistory : AuditableEntity
    {
        public long Id { get; set; }
        public int OrderId { get; set; }
        public OrderStatus? PreviousStatusId { get; set; }
        public OrderStatus NewStatusId { get; set; }
        public string? Remarks { get; set; }
        public Order Order { get; set; } = null!;
        public OrderStatusMaster? PreviousStatus { get; set; }
        public OrderStatusMaster NewStatus { get; set; } = null!;
    }
}
