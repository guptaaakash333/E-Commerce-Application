using ECommerceAPI.Entities;
using System.ComponentModel.DataAnnotations;
using Twilio.TwiML.Voice;
using Twilio.Types;
namespace ECommerceAPI.DTOs.Requests
{
    /// <summary>
    /// Page: Login Page
    /// It contains the Email and Password entered by the Customer.The API uses them to authenticate the Customer.
    /// If 2FA is disabled, successful Login produces Tokens immediately.If 2FA is enabled, Login continues to the 2FA verification step.
    /// </summary>    
    public sealed class LoginRequestDTO
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please provide a valid Email address.")]
        [StringLength(256)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, ErrorMessage = "Password cannot exceed 100 characters.")]
        public string Password { get; set; } = string.Empty;
    }
}
