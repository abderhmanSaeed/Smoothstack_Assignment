Order Management System API
Overview
This API simulates an order management system, providing functionalities to handle customer orders, apply discounts based on customer segments, and track the status of orders. The API also offers analytics related to orders such as average values and fulfillment times.

Features
Discount Calculation: Calculates discounts based on customer segments (VIP/Regular) and order totals.

Order Status Tracking: Supports tracking of order statuses with appropriate state transitions.

Order Analytics: Provides average order value and fulfillment time analytics.

API Documentation: Swagger/OpenAPI documentation for easy interaction with the API endpoints.

Installation
Prerequisites
.NET 8 SDK installed.

Visual Studio 2022 or any preferred IDE.

Steps to Run the Project
Clone the repository:


git clone https://github.com/abderhmanSaeed/Smoothstack_Assignment.git
Navigate to the project directory:


cd OrderManagementAPI
Restore dependencies:


dotnet restore
Run the application:


dotnet run
The API will be available at http://localhost:5000.

Access the Swagger documentation at http://localhost:5000/swagger to view and interact with the API endpoints.

API Endpoints
1. POST /api/discount/calculate
Calculates the discount based on customer segment and order items.

Request Body
json
Copy
Edit
{
  "customer": {
    "id": 1,
    "name": "John Doe",
    "segment": "VIP"
  },
  "orderItems": [
    {
      "quantity": 10,
      "unitPrice": 150
    }
  ]
}
Response
json
Copy
Edit
{
  "discount": 150
}
2. GET /api/orders/analytics
Returns order analytics, such as average order value and average fulfillment time.

Response

{
  "averageOrderValue": 1000,
  "averageFulfillmentTime": "3 days"
}
Testing
Unit Tests for Discount Calculation
The CalculateDiscount method in the DiscountService class applies a discount based on the customer's segment (VIP or Regular) and the total order value.

Unit tests are written to verify the functionality of the CalculateDiscount method. They check the discount for different customer segments.

Example Unit Test (VIP Customer):

[Test]
public void CalculateDiscount_ShouldApplyVIPDiscount_WhenTotalAmountExceedsThreshold()
{
    // Arrange
    var customer = new Customer { Segment = CustomerSegment.VIP };
    var orderItems = new List<OrderItem>
    {
        new OrderItem { Quantity = 10, UnitPrice = 150 }
    };

    // Act
    var discount = _discountService.CalculateDiscount(customer, orderItems);

    // Assert
    Assert.AreEqual(150, discount); // 10% of 1500
}
Running Tests
To run tests using NUnit, follow these steps:

Restore dependencies:


dotnet restore
Run the tests:


dotnet test
Performance Optimization
In this iteration, the API is designed to calculate discounts and handle order analytics efficiently. To further optimize:

Caching: Introduce caching for frequently accessed order analytics to reduce processing time.

Asynchronous Operations: Use asynchronous programming for database access and external API calls.

Future Enhancements
Add additional customer segments and more complex discount rules.

Implement authentication and authorization for secure API access.

Extend order status tracking with more granular status updates and transitions.

Contributing
Feel free to fork the repository, submit issues, and create pull requests for any improvements or bug fixes.

License
This project is licensed under the MIT License - see the LICENSE file for details.
