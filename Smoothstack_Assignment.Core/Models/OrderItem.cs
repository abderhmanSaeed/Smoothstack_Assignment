using RepositoryPatternWithUOW.Core.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothstack_Assignment.Core.Models
{
    /// <summary>
    /// Represents a single item in an order.
    /// </summary>
    public class OrderItem : BaseEntity
    {
        /// <summary>
        /// Gets or sets the ID of the order this item belongs to.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the parent order of this item.
        /// </summary>
        public Order? Order { get; set; }

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        public string? ProductName { get; set; }

        /// <summary>
        /// Gets or sets the quantity of the product ordered.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit price of the product.
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets the total price for this order item (Quantity * UnitPrice).
        /// </summary>
        public decimal TotalPrice => Quantity * UnitPrice;
    }

}
