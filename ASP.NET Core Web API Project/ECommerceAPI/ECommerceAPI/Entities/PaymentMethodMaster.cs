using ECommerceAPI.Enums;
namespace ECommerceAPI.Entities
{
    /// <summary>
    /// The PaymentMethodMaster entity stores available payment methods in the database. 
    /// The Id values correspond to the PaymentMethod enum values, while properties such as Name, Description, IsActive, 
    /// and DisplayOrder allow payment methods to be managed from the database.
    /// </summary>

    public sealed class PaymentMethodMaster : AuditableEntity
    {
        public PaymentMethod Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool RequiresOnlinePayment { get; set; }
        public bool IsActive { get; set; } = true;
        public int DisplayOrder { get; set; }
    }
}
