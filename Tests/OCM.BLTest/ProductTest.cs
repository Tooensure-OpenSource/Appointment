using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCM.BL;
using System;

namespace OCM.BLTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ProductSuccessful()
        {
            // Arrange
            var product = new Product
            {
                Name = "Kids Chiecken and fries",
                Description = "3 wings, with fries and bread",
                CurrentPrice = 00.00M
            };

            var expected = "Kids Chiecken and fries - 0.00";
            // Act
            var actual = product.ProductItem;

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ProductNameEmpty()
        {
            // Arrange
            var product = new Product
            {
                Name = null,
                Description = "3 wings, with fries and bread",
                CurrentPrice = 00.00M
            };

            var expected = "Invalid Product";

            // Act
            var actual = product.ProductItem;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductPriceEmpty()
        {
            // Arrange
            var product = new Product
            {
                Name = "Kids Chiecken and fries",
                Description = "3 wings, with fries and bread",
                CurrentPrice = null
            };

            var expected = "Invalid Product";

            // Act
            var actual = product.ProductItem;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductVerifyInvalidName()
        {
            // Arrange
            var product = new Product
            {
                Name = null,
                Description = "3 wings, with fries and bread",
                CurrentPrice = 00.00M
            };

            var expected = false;

            // Act
            var actual = product.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductVerifyInvalidPrice()
        {
            // Arrange
            var product = new Product
            {
                Name = "Kids Chiecken and fries",
                Description = "3 wings, with fries and bread",
                CurrentPrice = null
            };

            var expected = false;

            // Act
            var actual = product.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductVerifyValid()
        {
            // Arrange
            var product = new Product
            {
                Name = "Kids Chiecken and fries",
                Description = "3 wings, with fries and bread",
                CurrentPrice = 00.00M
            };

            var expected = true;

            // Act
            var actual = product.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
