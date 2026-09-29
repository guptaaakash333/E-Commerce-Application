using Microsoft.Identity.Client.NativeInterop;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using Twilio.Types;

namespace ECommerceAPI.DTOs.Requests
{
    /// <summary>
    /// Page: Edit Address Page
    /// It contains the editable Address information.This DTO is used to modify an existing Customer Address.
    /// The Address Id should come from the route /api/addresses/5. Therefore, it does not need to be repeated inside the Request DTO.
    /// </summary>

    public sealed class UpdateCustomerAddressRequestDTO
    {
        [Required(ErrorMessage = "Full Name is required.")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "Full Name must be between 2 and 150 characters.")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^\+?[1-9]\d{7,14}$", ErrorMessage = "Please provide a valid Mobile Number.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address Line 1 is required.")]
        [StringLength(200)]
        public string AddressLine1 { get; set; } = string.Empty;

        [StringLength(200)]
        public string? AddressLine2 { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [StringLength(100)]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "State is required.")]
        [StringLength(100)]
        public string State { get; set; } = string.Empty;

        [Required(ErrorMessage = "Postal Code is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Please provide a valid Postal Code.")]
        public string PostalCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Country is required.")]
        [StringLength(100)]
        public string Country { get; set; } = string.Empty;

        public bool IsDefaultShipping { get; set; }

        public bool IsDefaultBilling { get; set; }
    }
}
