using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCM.BL;
using OCM.BL.Repositories;
using System;

namespace OCM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveProduct()
        {
            // Arrange
            var product = new ProductRepository();
            var expect = new Product
            {
                Name = "Cheese Burger",
                Description = "1 Bun, meat and cheese",
                CurrentPrice = 1.00M

            };

            // Act
            var actual = product.Retrieve(1);

            // Assert
            Assert.AreEqual(expect.Name, actual.Name);
            Assert.AreEqual(expect.Description, actual.Description);
            Assert.AreEqual(expect.CurrentPrice, actual.CurrentPrice);
        }
    }
}
