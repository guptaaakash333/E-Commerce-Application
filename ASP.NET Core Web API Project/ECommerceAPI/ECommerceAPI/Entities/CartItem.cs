namespace ECommerceAPI.Entities
{
    /// <summary>
    /// The CartItem entity represents an individual product added to a customer's shopping cart.
    /// It stores the selected product and the quantity the customer wants to purchase.
    /// </summary>
    /// 
    public sealed class CartItem : AuditableEntity
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Cart Cart { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }

}
