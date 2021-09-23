using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCM.BL;
using System;

namespace OCM.BLTest
{
    [TestClass]
    public class ServiceItemTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var serviceItem = new ServiceItem
            {
                Name = "Hair Line",
                Description = "Clean front, side and back hair line",
                Cost = 10.00M
            };
            var expect = true;

            // Act
            var actual = serviceItem.Validate();

            // Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void ValidateInvalid()
        {
            // Arrange
            var serviceItem = new ServiceItem
            {
                Name = "",
                Description = "Clean front, side and back hair line",
                Cost = 10.00M
            };
            var expect = false;

            // Act
            var actual = serviceItem.Validate();

            // Assert
            Assert.AreEqual(expect, actual);
        }
    }
}
