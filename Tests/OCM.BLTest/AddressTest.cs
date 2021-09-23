using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OCM.BL;

namespace OCM.BLTest
{
    [TestClass]
    public class AddressTest
    {
        [TestMethod]
        public void ValidateRequirements()
        {
            // Arrange
            var address = new Address
            {
                StreetLine1 = "1447",
                StreetLine2 = "East 7",
                City = "Saint Paul",
                State = "Minnesota",
                Country = "USA",
                PostalCode = 55106,
                AddressType = "apt 11"
            };

            var expect = true;

            // Act
            var actual = address.Validate();

            // Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void InvalidateRequirements()
        {
            // Arrange
            var address = new Address
            {
                StreetLine1 = "",
                StreetLine2 = "East 7",
                City = "Saint Paul",
                State = "Minnesota",
                Country = "USA",
                PostalCode = 55106,
                AddressType = "apt 11"
            };

            var expect = false;

            // Act
            var actual = address.Validate();
            // Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void InvalidatePostalCodeNull()
        {
            // Arrange
            var address = new Address
            {
                StreetLine1 = "1447",
                StreetLine2 = "East 7",
                City = "Saint Paul",
                State = "Minnesota",
                Country = "USA",
                PostalCode = null,
                AddressType = "apt 11"
            };

            var expect = false;

            // Act
            var actual = address.Validate();

            // Assert
            Assert.AreEqual(expect, actual);
        }
    }
}
