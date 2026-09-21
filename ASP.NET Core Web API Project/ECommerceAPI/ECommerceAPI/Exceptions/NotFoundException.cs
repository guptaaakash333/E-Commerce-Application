namespace ECommerceAPI.Exceptions
{
    /// <summary>
    /// The NotFoundException represents a situation where a requested resource cannot be found. 
    /// For example, it can represent a missing Product, Customer, Address, Shopping Cart, or Order.
    /// 
    /// This exception will be converted into: 404 Not Found
    /// </summary>

    public sealed class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
