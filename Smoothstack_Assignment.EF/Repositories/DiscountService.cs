using Smoothstack_Assignment.Core.Enums;
using Smoothstack_Assignment.Core.Interfaces;
using Smoothstack_Assignment.Core.Models;
using Smoothstack_AssignmentCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothstack_Assignment.EF.Repositories
{
    /// <summary>
    /// Service to handle discount calculations based on customer type and order items.
    /// </summary>
    public class DiscountService : IDiscountService
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountService"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work instance to handle database operations.</param>
        public DiscountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Calculates the discount for the customer based on their segment and the total order amount.
        /// </summary>
        /// <param name="customer">The customer for whom the discount is being calculated.</param>
        /// <param name="orderItems">A collection of order items to calculate the total amount.</param>
        /// <returns>The calculated discount amount.</returns>
        public decimal CalculateDiscount(Customer customer, IEnumerable<OrderItem> orderItems)
        {
            // حساب المبلغ الإجمالي للطلب
            decimal totalAmount = orderItems.Sum(item => item.Quantity * item.UnitPrice);
            decimal discount = 0;

            // تطبيق قواعد الخصم بناءً على نوع العميل
            if (customer.Segment == CustomerSegment.VIP && totalAmount > 1000)
            {
                discount = totalAmount * 0.1m; // خصم 10%
            }
            else if (customer.Segment == CustomerSegment.Regular && totalAmount > 500)
            {
                discount = totalAmount * 0.05m; // خصم 5%
            }

            return discount;
        }
    }

}
