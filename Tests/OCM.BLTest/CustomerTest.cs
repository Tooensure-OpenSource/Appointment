using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCM.BL;
using System;

namespace OCM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            var customer = new Customer
            {
                FirstName = "Shawn",
                LastName = "Doe"
            };

            string expected = "Doe, Shawn";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            var customer = new Customer
            {
                LastName = "Doe"
            };

            string expected = "Doe";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            var customer = new Customer
            {
                FirstName = "Shawn"
            };

            string expected = "Shawn";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var customer1 = new Customer();
            customer1.FirstName = "Shawn";
            Customer.InstanceCount += 1;

            var customer2 = new Customer();
            customer1.FirstName = "Mike";
            Customer.InstanceCount += 1;

            var customer3 = new Customer();
            customer1.FirstName = "Kay";
            Customer.InstanceCount += 1;

            //-- Act

            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);

        }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var customer = new Customer()
            {
                FirstName = "Shawn",
                LastName = "Doe",
                EmailAddress = "tooensuremaster@gmail.com"
            };

            var expected = true;

            //-- Act
            bool actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidateInvalid()
        {
            //-- Arrange
            var customer = new Customer()
            {
                FirstName = "Shawn",
                LastName = "",
                EmailAddress = ""
            };
            var expected = false;

            //-- Act
            bool actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            var customer = new Customer()
            {
                FirstName = "Shawn",
                EmailAddress = "tooensuremaster@gmail.com"
            };
            var expected = false;

            //-- Act
            bool actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidateMissingEmailAddress()
        {
            //-- Arrange
            var customer = new Customer()
            {
                FirstName = "Shawn",
                LastName = "Doe"
            };
            var expected = false;

            //-- Act
            bool actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
