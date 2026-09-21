# Exceptions/GlobalExceptionHandler.cs

Now, we will create our Global Exception handler. The ASP.NET Core framework provides the `IExceptionHandler` interface for implementing centralized exception handling. Our Global Exception Handler will:
- Identify the Exception type
- Assign the appropriate HTTP Status Code
- Log the Exception details
- Return the error using our common `ApiResponse<T>` structure
- Include the request Trace Id

## Exception and HTTP Status Code Mapping
The Global Exception Handler uses the following mapping:
- `NotFoundException` → 404 Not Found
- `BusinessException` → 400 Bad Request
- `ConflictException` → 409 Conflict
- `UnauthorizedAccessException` → 401 Unauthorized
- `DbUpdateConcurrencyException` → 409 Conflict
- Other Exceptions → 500 Internal Server Error

> **Note:** `UnauthorizedAccessException` and `DbUpdateConcurrencyException` are built-in exceptions, so we do not need to create separate Custom Exception classes for them.

### Why Do We Handle DbUpdateConcurrencyException?
Some entities in our application use a `RowVersion` column for optimistic concurrency, such as `Product`, `Cart`, `Order`, `RefreshToken`, `VerificationCode`, and `PaymentTransaction`. EF Core can throw `DbUpdateConcurrencyException` when another request modifies the same record before the current request saves its changes.

Therefore, Entity Framework Core can throw a `DbUpdateConcurrencyException` when the same record is modified concurrently. For such cases, our Global Exception Handler returns: 
- **409 Conflict**


### Note:
	UnauthorizedAccessException and DbUpdateConcurrencyException are built-in exceptions, so we do not need to create separate Custom Exception classes for them.
	Therefore, Entity Framework Core can throw a DbUpdateConcurrencyException when the same record is modified concurrently. For such cases, our Global Exception Handler returns: 
      -> 409 Conflict

