namespace ECommerceAPI.DTOs.Responses
{
    /// <summary>
    /// Page: Checkout Page
    /// It represents payment options such as:
    /// -Cash on Delivery
    /// -Card
    /// -UPI
    /// It also contains RequiresOnlinePayment, which helps the application distinguish COD from Card/UPI.
    /// </summary>

    public sealed class PaymentMethodResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool RequiresOnlinePayment { get; set; }
    }
}
