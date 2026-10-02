namespace ECommerceAPI.DTOs.Responses
{
    /// <summary>
    /// Page: Shopping Cart Page
    /// The CartResponseDTO represents the Customer's complete Shopping Cart including the collection of Cart Items.
    /// </summary>

    public sealed class CartResponseDTO
    {
        public int CartId { get; set; }
        public int TotalItems { get; set; }
        public decimal CartTotal { get; set; }
        public List<CartItemResponseDTO> Items { get; set; } = new List<CartItemResponseDTO>();
    }
}
