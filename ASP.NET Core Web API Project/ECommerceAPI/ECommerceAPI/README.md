## Core Building Blocks

- We will create the core building blocks required by our E-Commerce Web API.
- We will start with Enums to represent fixed application values such as Payment Method, Payment Status, Order Status, Notification Channel,
   and Notification Status. 

- Then, we will create Master Entities to store reference data in the database and Transactional Entities to represent actual business data 
   such as Customers, Products, Shopping Carts, Orders, Payments, and Notifications.

- We will also create a few Common Models that will be used internally by the application for pagination, token generation, and payment processing. 

* Finally, we will create Options Classes to strongly type the configuration values available in appsettings.json, such as Pricing, JWT, Verifications, Email, Twilio, and Notification settings.


---

### 1. Enums
Used to represent fixed application values:
* **Payment Method**
* **Payment Status**
* **Order Status**
* **Notification Channel**
* **Notification Status**

---

### 2. Entities
* **Master Entities:** Store reference data in the database.
* **Transactional Entities:** Represent actual business data, including:
  * Customers
  * Products
  * Shopping Carts
  * Orders
  * Payments
  * Notifications

---

### 3. Common Models
Internal models used by the application for:
* **Pagination**
* **Token Generation**
* **Payment Processing**

---

### 4. Options Classes
Strongly typed classes mapping configuration values from `appsettings.json`:
* **Pricing Settings**
* **JWT Settings**
* **Verifications Settings**
* **Email Settings**
* **Twilio Settings**
* **Notification Settings**