namespace ECommerceAPI.Models
{
    /// <summary>
    /// The PagedResult<T> class represents paginated data returned by the application. 
    /// It contains the requested page information, total number of records, total pages, and the collection of items for the current page.
    /// </summary>

    public sealed class PagedResult<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
        public List<T> Items { get; set; } = new List<T>();
    }
}
