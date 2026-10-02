
using Microsoft.VisualBasic;

/// <summary>
/// DTOs/Responses/CustomerResponseDTO.cs
/// Used After: Registration and Authentication
/// The CustomerResponseDTO represents Customer information returned by the application. 
/// The Password Hash is intentionally not included in the Response DTO.
/// </summary>

namespace ECommerceAPI.DTOs.Responses
{
    /// <summary>
    /// Used After: Registration and Authentication
    /// The CustomerResponseDTO represents Customer information returned by the application.
    /// The Password Hash is intentionally not included in the Response DTO.
    /// </summary>

    public sealed class CustomerResponseDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public bool IsEmailConfirmed { get; set; }
        public bool IsMobileConfirmed { get; set; }
        public bool IsTwoFactorEnabled { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAtUtc { get; set; }
    }
}
