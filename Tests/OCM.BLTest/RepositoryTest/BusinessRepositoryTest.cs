using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCM.BL;
using OCM.BL.Repositories;
using System;

namespace OCM.BLTest.RepositoryTest
{
    [TestClass]
    public class BusinessRepositoryTest
    {
        [TestMethod]
        public void Retrieve()
        {
            // Arrange
            var business = new BusinessRepository();
            var expert = new Business(1)
            {
                Name = "Tooensure LLC"
            };

            // Act
            var actual = business.Retrieve(1);

            // Assert
            Assert.AreEqual(expert.Name, actual.Name);
        }
    }
}
