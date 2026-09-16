using Twilio.TwiML.Voice;

namespace ECommerceAPI.Entities
{
    /// <summary>
    /// The Cart entity represents the shopping cart of a customer.
    /// Each customer has a cart containing the products they intend to purchase before proceeding to checkout.
    /// </summary>
    /// 
    public sealed class Cart : AuditableEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public byte[] RowVersion { get; set; } = Array.Empty<byte>();

        public ICollection<CartItem> Items { get; set; } = new List<CartItem>();
    }
}
