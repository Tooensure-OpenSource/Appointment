using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCM.BL;
using System;

namespace OCM.BLTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void UserWithEmailPassword()
        {
            // Assert
            var user = new User
            {
                Email = "tooensuremaster@gmail.com",
                Password = "1234"
            };
            
            var expect = "Response = Success, Email = True, Password = True";

            // Act
            var actual = user.Auth;

            // Arrange
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void UserMissingPassword()
        {
            // Assert
            var user = new User
            {
                Email = "tooensuremaster@gmail.com",
                Password = ""
            };

            var expect = "Response = Error, Email = True, Password = False";

            // Act
            var actual = user.Auth;

            // Arrange
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void UserMissingEmail()
        {
            // Assert
            var user = new User
            {
                Password = "1234",
                Email = ""
            };

            var expect = "Response = Error, Email = False, Password = True";

            // Act
            var actual = user.Auth;

            // Arrange
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void UserVerifyWithoutEmail()
        {
            // Assert
            var user = new User
            {
                Password = "1234",
                Email = ""
            };

            var expect = false;

            // Act
            var actual = user.Validate();

            // Arrange
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void UserVerifyWithoutPassword()
        {
            // Assert
            var user = new User
            {
                Password = "1234",
                Email = ""
            };

            var expect = false;

            // Act
            var actual = user.Validate();

            // Arrange
            Assert.AreEqual(expect, actual);
        }
    }
}
