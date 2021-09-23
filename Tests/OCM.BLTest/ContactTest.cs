using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCM.BL;
using System;

namespace OCM.BLTest
{
    [TestClass]
    public class ContactTest
    {
        [TestMethod]
        public void PhoneNumber()
        {
            // Arrange
            var contact = new Contact
            {
                PhoneNumber = "000-000-0000"
            };

            var expect = "000-000-0000";

            // Act
            var actual = contact.PhoneNumber;

            // Assert
            Assert.AreEqual(expect, actual);
        }
    }
}
