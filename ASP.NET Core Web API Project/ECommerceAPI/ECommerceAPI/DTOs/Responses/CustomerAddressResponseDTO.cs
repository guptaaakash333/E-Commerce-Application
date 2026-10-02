namespace ECommerceAPI.DTOs.Responses
{
    /// <summary>
    /// Page: Address Management Page and Checkout Page
    /// It represents the Customer Address.It also contains:
    /// -IsDefaultShipping
    /// -IsDefaultBilling
    /// So Angular can determine which addresses are defaults. 
    /// </summary>

    public sealed class CustomerAddressResponseDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string AddressLine1 { get; set; } = string.Empty;
        public string? AddressLine2 { get; set; }
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public bool IsDefaultShipping { get; set; }
        public bool IsDefaultBilling { get; set; }
    }
}
