#region Summary of the Implementation
//The `VerificationCodeHelper` class provides a complete utility for managing One-Time Passwords (OTPs) and verification codes:

//-**Secure Generation * *: Uses `RandomNumberGenerator.GetInt32(100000, 1000000)` to generate cryptographically secure 6-digit numeric codes ($100000 \le \text{code} \le 999999$).
//- **Cryptographic Hashing**: Leverages `PasswordHasher<VerificationCode>` from ASP.NET Core Identity to hash the raw verification code before storing it in the database.
//- **Verification**: Uses `VerifyHashedPassword` to validate incoming user codes against the stored hash safely.

//---

//### Cleaned Code Reference 
#endregion

using ECommerceAPI.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client.Extensions.Msal;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using Twilio.TwiML.Voice;
using Twilio.Types;

namespace ECommerceAPI.Helpers
{
    /// <summary>
    /// This helper will:
    /// -Generate the 6 - digit code
    /// -Hash the code before database storage
    /// -Verify the submitted code against the stored hash
    /// </summary>

    public static class VerificationCodeHelper
    {
        /// <summary>
        /// Generates a secure random 6-digit verification code.
        /// RandomNumberGenerator.GetInt32 uses a cryptographically secure
        /// random number generator, which is more suitable for OTPs  and verification codes.
        /// 
        /// The minimum value is inclusive and the maximum value is exclusive.
        /// So this generates values from:
        /// 100000 to 999999
        /// Example: 483721
        /// </summary>
        public static string GenerateCode()
        {
            return RandomNumberGenerator.GetInt32(100000, 1000000).ToString();
        }


        /// <summary>
        /// Converts the plain verification code into a secure hash
        /// before storing it in the database.
        /// Example:
        /// Plain Code: 483721
        /// Stored Value: AQAAAAIAAYagAAAAE...
        /// We should store the hash instead of storing
        /// the original verification code in plain text.
        /// </summary>
        /// <param name="verificationCode"></param>
        /// <param name="code"></param>
        public static string HashCode(VerificationCode verificationCode, string code)
        {
            // Create ASP.NET Core Identity's password hasher.
            // Although this class is commonly used for passwords,
            // it can also securely hash values such as verification codes.
            var passwordHasher = new PasswordHasher<VerificationCode>();

            // Hash the verification code and return the generated hash.
            // The VerificationCode entity is also supplied as context to the PasswordHasher.
            return passwordHasher.HashPassword(verificationCode, code);
        }


        /// <summary>
        /// Verifies whether the verification code entered by the user
        /// matches the previously stored hash.
        /// </summary>
        /// <param name="verificationCode"></param>
        /// <param name="codeHash"></param>
        /// <param name="code"></param>
        /// <returns></returns>        
        public static bool VerifyCode(VerificationCode verificationCode, string codeHash, string code)
        {
            // Create the same ASP.NET Core Identity password hasher
            // that is used for hashing the verification code.
            var passwordHasher = new PasswordHasher<VerificationCode>();

            // Compare the plain verification code entered by the user
            // with the hashed verification code stored in the database.
            var result = passwordHasher.VerifyHashedPassword(verificationCode, codeHash, code);

            // VerifyHashedPassword can return:
            // Failed
            // Success
            return result != PasswordVerificationResult.Failed;
        }


        //Note: PasswordHasher is a generic type and expect Tuser.
        //TUser is provided so the password hasher can have access to the associated user object while hashing or verifying.
        //This makes the hashing abstraction flexible enough to support custom user-specific hashing logic,
        //even though the default ASP.NET Core password hasher does not use the user's properties.
    }
}
