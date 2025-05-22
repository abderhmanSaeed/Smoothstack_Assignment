using RepositoryPatternWithUOW.Core.BaseEntity;
using Smoothstack_Assignment.Core.Consts;
using Smoothstack_Assignment.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoothstack_Assignment.Core.Models
{
    /// <summary>
    /// Represents a customer in the order management system.
    /// </summary>
    public class Customer : BaseEntity
    {
        /// <summary>
        /// Gets or sets the customer's full name.
        /// </summary>
        public  string? Name { get; set; }

        /// <summary>
        /// Gets or sets the customer's email address.
        /// </summary>
        public  string? Email { get; set; }

        /// <summary>
        /// Gets or sets the customer's segment (e.g., New, Regular, VIP).
        /// </summary>
        public CustomerSegment Segment { get; set; }

        /// <summary>
        /// Gets or sets the collection of orders made by the customer.
        /// </summary>
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }

}
