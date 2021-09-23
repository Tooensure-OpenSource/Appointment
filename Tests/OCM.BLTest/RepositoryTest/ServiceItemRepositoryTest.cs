using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCM.BL;
using OCM.BL.Repositories;
using System;

namespace OCM.BLTest.RepositoryTest
{
    [TestClass]
    public class ServiceItemRepositoryTest
    {
        [TestMethod]
        public void Retrieve()
        {
            // Arrange
            var serviceItem = new ServiceItemRepository();
            var expect = new ServiceItem(1)
            {
                Name = "Basic hairline Cut",
                Description = "Clean front, back and side cut",
                Cost = 10.00M
            };

            // Act
            var actual = serviceItem.Retrieve(1);

            // Assert
            Assert.AreEqual(expect.Name, actual.Name);
            Assert.AreEqual(expect.Description, actual.Description);
            Assert.AreEqual(expect.Cost, actual.Cost);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            // Arrange
            var serviceItemRepository = new ServiceItemRepository();
            var updatedServiceItem = new ServiceItem(2)
            {
                Name = "Basic hairline Cut",
                Description = "Clean front, back and side cut",
                Cost = null,
                HasChanges = true
            };

            // Act
            var actual = serviceItemRepository.Save(updatedServiceItem);

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            // Arrange
            var serviceItemRepository = new ServiceItemRepository();
            var updatedServiceItem = new ServiceItem(2)
            {
                Name = "Basic hairline Cut",
                Description = "Clean front, back and side cut",
                Cost = 10.00M,
                HasChanges = true,
                IsNew = true,
               
            };

            // Act
            var actual = serviceItemRepository.Save(updatedServiceItem);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestNameInvalid()
        {
            // Arrange
            var serviceItemRepository = new ServiceItemRepository();
            var updatedServiceItem = new ServiceItem(2)
            {
                Name = "",
                Description = "Clean front, back and side cut",
                Cost = 10.00M,
                HasChanges = true,
                IsNew = true,

            };

            // Act
            var actual = serviceItemRepository.Save(updatedServiceItem);

            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}
