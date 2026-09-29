using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using Twilio.TwiML.Fax;
namespace ECommerceAPI.DTOs.Requests
{
    /// <summary>
    /// Page: Email Verification Page
    /// This DTO is used when the Customer did not receive the Email Verification Code or the previous code expired.
    /// </summary>

    public sealed class ResendEmailVerificationCodeRequestDTO
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please provide a valid Email address.")]
        [StringLength(256)]
        public string Email { get; set; } = string.Empty;
    }
}
