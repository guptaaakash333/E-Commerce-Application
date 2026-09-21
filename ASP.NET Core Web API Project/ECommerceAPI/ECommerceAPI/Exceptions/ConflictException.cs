namespace ECommerceAPI.Exceptions
{
    /// <summary>
    /// The ConflictException represents a request that conflicts with existing application data. 
    /// In our application, it is used when a customer attempts to register using an Email Address or Mobile Number that is already registered. It also handles concurrent registration requests where the database unique constraint detects the conflict.
    /// </summary>

    public sealed class ConflictException : Exception
    {
        public ConflictException(string message) : base(message)
        {
        }
    }
}
