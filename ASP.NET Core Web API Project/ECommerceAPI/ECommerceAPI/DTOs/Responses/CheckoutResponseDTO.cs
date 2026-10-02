using ECommerceAPI.Entities;

namespace ECommerceAPI.DTOs.Responses
{
    /// <summary>
    /// Page: Checkout Page.
    /// CheckoutResponseDTO is a composite DTO containing the Checkout Token, Cart Items, Pricing, Customer Addresses, and Payment Methods.It contains:
    /// -List<CheckoutItemResponseDTO>
    /// -PricingSummaryResponseDTO
    /// -List < CustomerAddressResponseDTO >
    /// -List < PaymentMethodResponseDTO >
    /// -CheckoutToken
    /// This DTO gives Angular everything required to initially render the Checkout page.
    /// </summary>



    public sealed class CheckoutResponseDTO
    {
        public Guid CheckoutToken { get; set; }

        public List<CheckoutItemResponseDTO> Items { get; set; }
            = new List<CheckoutItemResponseDTO>();

        public PricingSummaryResponseDTO Pricing { get; set; } = null!;

        public List<CustomerAddressResponseDTO> Addresses { get; set; }
            = new List<CustomerAddressResponseDTO>();

        public List<PaymentMethodResponseDTO> PaymentMethods { get; set; }
            = new List<PaymentMethodResponseDTO>();
    }
}
