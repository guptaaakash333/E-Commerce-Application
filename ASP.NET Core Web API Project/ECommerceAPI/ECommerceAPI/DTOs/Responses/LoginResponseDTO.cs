using Azure;
using System.Numerics;

namespace ECommerceAPI.DTOs.Responses
{
    namespace ECommerceAPI.DTOs.Responses
    {
        /// <summary>
        /// Page: Login Flow
        /// The LoginResponseDTO represents the result of the Login operation.
        /// If Two-Factor Authentication is enabled, 
        /// RequiresTwoFactor will be true and Tokens will not be generated until 2FA verification is completed.
        /// </summary>

        public sealed class LoginResponseDTO
        {
            public bool RequiresTwoFactor { get; set; }
            public CustomerResponseDTO? Customer { get; set; }
            public TokenResponseDTO? Tokens { get; set; }
        }
    }

}
