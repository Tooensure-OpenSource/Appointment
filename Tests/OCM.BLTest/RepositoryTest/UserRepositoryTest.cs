using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCM.BL;
using OCM.BL.Repositories;
using System;

namespace OCM.BLTest
{
    [TestClass]
    public class UserRepositoryTest
    {
        [TestMethod]
        public void RetrieveUser()
        {
            // Arrange
            var user = new UserRepository();
            var expect = new User
            {
                Email = "tooensurellc@gmail.com",
                Password = "1234"
            };

            // Act
            var actual = user.Retrieve(1);

            // Assert
            Assert.AreEqual(expect.Email, actual.Email);
            Assert.AreEqual(expect.Password, actual.Password);
        }
    }
}
