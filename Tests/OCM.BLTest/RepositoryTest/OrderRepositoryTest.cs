using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCM.BL;
using OCM.BL.Repositories;
using System;

namespace OCM.BLTest.RepositoryTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrder()
        {
            // Arrange
            var order = new OrderRepository();
            var expect = new Order(1)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            // Act
            var actual = order.Retrieve(1);

            // Assert
            Assert.AreEqual(expect.OrderDate, actual.OrderDate);
        }
    }
}
