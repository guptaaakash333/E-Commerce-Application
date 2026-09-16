namespace ECommerceAPI.Models
{
    /// <summary>
    /// The ApiResponse<T> class provides a common response structure for all API endpoints. 
    /// It allows every endpoint to return a consistent response containing success status, message, response data, 
    /// validation errors, and a trace identifier when required.
    /// </summary>


    public sealed class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }
        public IDictionary<string, string[]>? Errors { get; set; }
        public string? TraceId { get; set; }

        public static ApiResponse<T> SuccessResponse(T data, string message = "Request completed successfully.")
        {
            return new ApiResponse<T>
            {
                Success = true,
                Message = message,
                Data = data
            };
        }

        public static ApiResponse<T> FailureResponse(
            string message,
            IDictionary<string, string[]>? errors = null,
            string? traceId = null)
        {
            return new ApiResponse<T>
            {
                Success = false,
                Message = message,
                Errors = errors,
                TraceId = traceId
            };
        }
    }
}
