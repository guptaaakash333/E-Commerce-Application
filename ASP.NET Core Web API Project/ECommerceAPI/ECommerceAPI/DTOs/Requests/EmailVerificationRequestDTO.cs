using ECommerceAPI.Entities;
using System.ComponentModel.DataAnnotations;
namespace ECommerceAPI.DTOs.Requests
{
    /// <summary>
    /// Page: Email Verification Page
    /// After Registration, the Customer receives a 6-digit Email verification code.
    /// This DTO sends the Email address and Verification Code back to the API for verification.
    /// </summary>

    public sealed class EmailVerificationRequestDTO
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please provide a valid Email address.")]
        [StringLength(256)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Verification Code is required.")]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "Verification Code must contain exactly 6 digits.")]
        public string Code { get; set; } = string.Empty;
    }
}
