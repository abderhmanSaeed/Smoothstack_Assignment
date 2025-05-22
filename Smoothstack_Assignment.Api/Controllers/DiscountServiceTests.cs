using Moq;
using NUnit.Framework;
using Smoothstack_Assignment.Core.Enums;
using Smoothstack_Assignment.Core.Models;
using Smoothstack_Assignment.EF.Repositories;
using Smoothstack_AssignmentCore;

namespace Smoothstack_Assignment.Api.Controllers

{
    [TestFixture]
    public class DiscountServiceTests
    {
        private Mock<IUnitOfWork> _unitOfWorkMock;
        private DiscountService _discountService;

        [SetUp]
        public void SetUp()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _discountService = new DiscountService(_unitOfWorkMock.Object);
        }

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
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(150, discount); // 10% of 1500
        }
    }
}
