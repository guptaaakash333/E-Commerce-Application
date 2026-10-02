Data Annotations in Request DTOs are responsible for validating the structure and basic validity of client input.

Business validations will remain inside the Service Layer. For example:

* Email already registered
* Mobile Number already registered
* MinPrice greater than MaxPrice
* Product not found
* Product inactive
* Insufficient stock
* Address does not belong to the Customer
* Shopping Cart is empty
* Invalid Payment Method for the operation
* Email or Mobile not verified before enabling 2FA

These are business rules and should not be placed inside DTOs.

## Conclusion

In this part, we created the Request and Response DTOs required by our E-Commerce Web API application. 
	The Request DTOs use Data Annotation attributes for input validation, 
	while the Response DTOs provide clean API contracts without exposing our Entity classes directly. 
	These DTOs now provide the required data structures for implementing Authentication, Product Listing, Shopping Cart, Address Management, Checkout, Order Placement, Payments, Order History, and Order Details.