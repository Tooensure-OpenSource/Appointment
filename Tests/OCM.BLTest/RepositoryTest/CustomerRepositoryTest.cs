using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCM.BL;
using OCM.BL.Repositories;
using System;

namespace OCM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveCustomer()
        {
            // Arrange
            var customer = new CustomerRepository();

            var expect = new Customer(1)
            {
                EmailAddress = "tooensurellc@gmail.com",
                FirstName = "Shawn",
                LastName = "Doe"
            };

            // Act
            var actual = customer.Retrieve(1);

            // Assert
            Assert.AreEqual(expect.CustomerId, actual.CustomerId);
            Assert.AreEqual(expect.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expect.FirstName, actual.FirstName);
            Assert.AreEqual(expect.LastName, actual.LastName);
        }
    }
}
