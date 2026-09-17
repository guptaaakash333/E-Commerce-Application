namespace ECommerceAPI.Entities
{
    /// <summary>
    /// The OrderItem entity stores each product included in an order. 
    /// Product Name, SKU, Image URL, and Unit Price are copied into this table
    /// so that historical order information remains unchanged even if the original product information is modified later.
    /// </summary>

    public sealed class OrderItem : AuditableEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductSku { get; set; } = string.Empty;
        public string ProductImageUrl { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal LineTotal { get; set; }
        public Order Order { get; set; } = null!;
    }
}
