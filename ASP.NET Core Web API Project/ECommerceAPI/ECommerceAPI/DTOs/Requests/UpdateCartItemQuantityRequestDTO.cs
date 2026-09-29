using ECommerceAPI.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Twilio.Types;
namespace ECommerceAPI.DTOs.Requests
{
    /// <summary>
    /// Page: Shopping Cart Page
    /// It is used when the Customer increases or decreases the quantity of an existing Cart Item.
    /// The Cart Item Id comes from the route: /api/cart/items/10. The DTO contains only the new Quantity.
    /// </summary>

    public sealed class UpdateCartItemQuantityRequestDTO
    {
        [Range(1, 99, ErrorMessage = "Quantity must be between 1 and 99.")]
        public int Quantity { get; set; }
    }
}
