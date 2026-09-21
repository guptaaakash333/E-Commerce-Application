namespace ECommerceAPI.Exceptions
{
    /// <summary>
    /// The BusinessException represents a failure caused by an application business rule. 
    /// For example, 
    /// it can represent insufficient Product stock, an empty Shopping Cart, an invalid Order operation, or an invalid Checkout operation.
    /// 
    /// This exception will be converted into: 400 Bad Request
    /// </summary>


    public sealed class BusinessException : Exception
    {
        public BusinessException(string message) : base(message)
        {
        }
    }
}
