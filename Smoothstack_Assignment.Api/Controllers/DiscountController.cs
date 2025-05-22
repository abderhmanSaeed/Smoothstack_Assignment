using Microsoft.AspNetCore.Mvc;
using Smoothstack_Assignment.Core.Interfaces;
using Smoothstack_Assignment.Core.Models;

namespace Smoothstack_Assignment.Api.Controllers
{
    /// <summary>
    /// Controller responsible for handling discount-related requests.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountController"/> class.
        /// </summary>
        /// <param name="discountService">The discount service that handles the discount calculation logic.</param>
        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        /// <summary>
        /// Calculates the discount for a given customer and order items.
        /// </summary>
        /// <param name="customer">The customer for whom the discount is being calculated.</param>
        /// <param name="orderItems">The order items that the discount will be applied to.</param>
        /// <returns>The discount amount.</returns>
        /// <response code="200">Returns the discount value successfully.</response>
        /// <response code="400">If the customer or order items are invalid.</response>
        [HttpPost("calculate")]
        public ActionResult<decimal> CalculateDiscount([FromBody] Customer customer, [FromBody] IEnumerable<OrderItem> orderItems)
        {
            if (customer == null || orderItems == null)
            {
                return BadRequest("Invalid customer or order items.");
            }

            decimal discount = _discountService.CalculateDiscount(customer, orderItems);

            return Ok(discount);
        }
    }
}
