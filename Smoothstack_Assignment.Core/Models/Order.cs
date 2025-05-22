using RepositoryPatternWithUOW.Core.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothstack_Assignment.Core.Models
{
    /// <summary>
    /// Represents a customer's order, including its status, total, and discount.
    /// </summary>
    public class Order : BaseEntity
    {
        /// <summary>
        /// Gets or sets the creation date and time of the order.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the delivery date and time of the order (if delivered).
        /// </summary>
        public DateTime? DeliveredAt { get; set; }

        /// <summary>
        /// Gets or sets the current status of the order.
        /// </summary>
        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        /// <summary>
        /// Gets or sets the total value of the order before discount.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the discount value applied to the order.
        /// </summary>
        public decimal DiscountApplied { get; set; }

        /// <summary>
        /// Gets or sets the ID of the customer who placed the order.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the customer who placed the order.
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Gets or sets the collection of items included in the order.
        /// </summary>
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
    }

}
