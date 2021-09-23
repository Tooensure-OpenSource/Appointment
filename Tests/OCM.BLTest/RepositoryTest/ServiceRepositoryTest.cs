using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCM.BL;
using OCM.BL.Repositories;
using System;

namespace OCM.BLTest.RepositoryTest
{
    [TestClass]
    public class ServiceRepositoryTest
    {
        [TestMethod]
        public void Retrieve()
        {
            // Arrange
            var service = new ServiceRepository();
            var expect = new Service(1)
            {
                TotalCost = 1.00M
            };

            // Act
            var actual = service.Retrieve(1);

            // Assert
            Assert.AreEqual(expect.TotalCost, actual.TotalCost);
        }
    }
}
