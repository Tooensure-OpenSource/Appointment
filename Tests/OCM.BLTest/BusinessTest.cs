using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCM.BL;
using System;

namespace OCM.BLTest
{
    [TestClass]
    public class BusinessTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var business = new Business
            {
                Name = "Tooensure LLC",
            };
            var expect = true;

            // Act
            var actual = business.Validate();

            // Assert
            Assert.AreEqual(actual, expect);
        }

        [TestMethod]
        public void ValidateInValid()
        {
            // Arrange
            var business = new Business
            {
                Name = "",
            };
            var expect = false;

            // Act
            var actual = business.Validate();

            // Assert
            Assert.AreEqual(actual, expect);
        }
    }
}
