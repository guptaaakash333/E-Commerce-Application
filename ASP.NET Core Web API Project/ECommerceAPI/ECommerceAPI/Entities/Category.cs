namespace ECommerceAPI.Entities
{
    /// <summary>
    /// The Category entity represents a product category such as Electronics, Mobiles, Laptops, or Fashion. 
    /// Products are associated with categories so that they can be organized, filtered, and displayed appropriately on the Product Listing page.
    /// </summary>


    public sealed class Category : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public int DisplayOrder { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
