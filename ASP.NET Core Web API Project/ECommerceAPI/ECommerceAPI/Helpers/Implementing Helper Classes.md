# Implementing Helper Classes

In this section, we will implement the helper classes required by our E-Commerce Web API application. 
These utility and helper services handle core operational tasks across security, ordering, and pricing domains:

- **Password Hashing and Verification**: Securely hashing user passwords using strong cryptographic algorithms (such as BCrypt or Identity PasswordHasher) and verifying credentials upon login.
- **JWT Access Token Generation**: Creating signed JSON Web Tokens (JWT) containing standard claims (User ID, Email, Roles) for authentication.
- **Refresh Token Generation**: Producing cryptographically secure random strings used to request new access tokens without requiring re-authentication.
- **Refresh Token Hashing**: Storing hashed representations of refresh tokens in the database to prevent plain-text exposure in case of data leaks.
- **Refresh Token Revocation**: Managing token invalidation, blacklisting, or expiration checks during user logout or token rotation.
- **Pricing Calculation**: Calculating item subtotals, applying discounts, adding tax rates, and computing total order amounts accurately.
- **Order Number Generator**: Generating unique, human-readable, and sequential or epoch-based order tracking identifiers.
- **Verification Code Generation, Hashing, and Verification**: Generating short numeric or alphanumeric codes (e.g., OTPs for email/phone verification), storing their hashed versions, and validating user inputs.

## Authentication Configuration

We will also create an extension method to configure JWT Bearer Authentication cleanly, keeping the JWT setup and middleware registration outside `Program.cs` to maintain separation of concerns.