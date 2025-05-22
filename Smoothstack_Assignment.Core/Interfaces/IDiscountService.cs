using Smoothstack_Assignment.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothstack_Assignment.Core.Interfaces
{
    /// <summary>
    /// Service responsible for calculating applicable discounts on orders.
    /// </summary>
    public interface IDiscountService
    {
        /// <summary>
        /// Calculates the discount amount based on customer segment and order history.
        /// </summary>
        /// <param name="customer">The customer placing the order.</param>
        /// <param name="orderItems">The items in the order.</param>
        /// <returns>The total discount amount to apply.</returns>
        decimal CalculateDiscount(Customer customer, IEnumerable<OrderItem> orderItems);
    }


}
