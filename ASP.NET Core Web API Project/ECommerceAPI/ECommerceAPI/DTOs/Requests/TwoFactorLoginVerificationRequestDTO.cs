using System.ComponentModel.DataAnnotations;
namespace ECommerceAPI.DTOs.Requests
{
    /// <summary>
    /// Page: 2FA Verification Page shown during Login
    /// It contains the Customer's Email address and the 6-digit 2FA code sent to the verified Email address.  
    /// It is used only when IsTwoFactorEnabled = true.
    /// </summary>
    public sealed class TwoFactorLoginVerificationRequestDTO
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
