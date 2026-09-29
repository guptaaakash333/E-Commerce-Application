using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using Twilio.TwiML.Fax;
namespace ECommerceAPI.DTOs.Requests
{
    /// <summary>
    /// Page: Phone Number Verification Page
    /// This DTO is used when the Customer did not receive the Phone Number Verification Code or the previous code expired.
    /// </summary>

    public sealed class ResendMobileVerificationCodeRequestDTO
    {
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression(@"^\+?[1-9]\d{7,14}$", ErrorMessage = "Please provide a valid Mobile Number.")]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
