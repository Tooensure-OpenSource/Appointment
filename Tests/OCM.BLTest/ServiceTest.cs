using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCM.BL;
using System;

namespace OCM.BLTest
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var service = new Service
            {
                TotalCost = 00.00M
            };
            var expect = true;

            // Act
            var actual = service.Validate();

            // Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void ValidateInvalid()
        {
            // Arrange
            var service = new Service
            {
                TotalCost = null
            };
            var expect = false;

            // Act
            var actual = service.Validate();

            // Assert
            Assert.AreEqual(expect, actual);
        }
    }
}
