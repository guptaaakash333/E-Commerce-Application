namespace ECommerceAPI.DTOs.Responses
{
    /// <summary>
    /// Page: Order Details / Order Tracking section.
    /// It represents one transition in the Order's status history:
    /// - Previous Status
    /// - New Status
    /// - Remarks
    /// - Changed Time
    ///
    /// </summary>

    public sealed class OrderStatusHistoryResponseDTO
    {
        public long Id { get; set; }
        public string? PreviousStatus { get; set; }
        public string NewStatus { get; set; } = string.Empty;
        public string? Remarks { get; set; }
        public DateTime ChangedAtUtc { get; set; }
    }
}
