using ECommerceAPI.Entities;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using static Twilio.Rest.Intelligence.V3.ConfigurationResource;
namespace ECommerceAPI.DTOs.Requests
{
    /// <summary>
    /// Page: Product Listing Page or Product Details Page
    /// When the Customer clicks Add to Cart, this DTO sends:
    /// -ProductId
    /// -Quantity
    /// The Customer does not need to send Price, Product Name, or Customer Id.
    /// The API obtains Product details from the database and Customer Id from JWT.
    /// </summary>
  
    public sealed class AddToCartRequestDTO
    {
        [Range(1, int.MaxValue, ErrorMessage = "Product Id must be greater than 0.")]
        public int ProductId { get; set; }

        [Range(1, 99, ErrorMessage = "Quantity must be between 1 and 99.")]
        public int Quantity { get; set; } = 1;
    }

    /// <summary>
    ///The Service will additionally verify:
    ///-Product exists
    ///-Product is active
    ///-Product has sufficient stock
    ///-Requested quantity does not exceed available stock
    /// These are business validations and should not be handled by Data Annotations.
    ///</summary>


}
