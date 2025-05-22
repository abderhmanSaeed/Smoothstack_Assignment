namespace Smoothstack_Assignment.Core.Enums
{
    /// <summary>
    /// Defines segments used to classify customers.
    /// </summary>
    public enum CustomerSegment
    {
        /// <summary>New customer with no or few orders.</summary>
        New,

        /// <summary>Customer with regular order history.</summary>
        Regular,

        /// <summary>High-value customer.</summary>
        VIP
    }

    /// <summary>
    /// Represents the various stages an order can be in.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>The order has been created but not yet processed.</summary>
        Pending,

        /// <summary>The order is being prepared for shipment.</summary>
        Processing,

        /// <summary>The order has been shipped.</summary>
        Shipped,

        /// <summary>The order has been delivered to the customer.</summary>
        Delivered,

        /// <summary>The order has been cancelled and will not be processed.</summary>
        Cancelled
    }

}
