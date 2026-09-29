using ECommerceAPI.Entities;
using ECommerceAPI.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace ECommerceAPI.DTOs.Requests
{
    /// <summary>
    /// Page: Checkout Page
    /// This is the final request sent when the Customer clicks Place Order.It contains only:
    /// -ShippingAddressId
    /// -BillingAddressId
    /// -PaymentMethod
    /// -CheckoutToken
    ///
    /// It correctly does not contain Customer, Products, Quantities, Prices, Tax, Shipping Charge, or Grand Total.
    /// Customer Id comes from JWT.
    /// Products and Quantities come from the Shopping Cart.
    /// Prices come from the Products table.
    /// Tax and Shipping are recalculated by the server.
    /// This prevents the client from manipulating Order information.
    /// </summary>

    public sealed class PlaceOrderRequestDTO
    {
        public Guid CheckoutToken { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Shipping Address Id must be greater than 0.")]
        public int ShippingAddressId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Billing Address Id must be greater than 0.")]
        public int BillingAddressId { get; set; }

        [EnumDataType(typeof(PaymentMethod), ErrorMessage = "Please select a valid Payment Method.")]
        public PaymentMethod PaymentMethod { get; set; }
    }
}
