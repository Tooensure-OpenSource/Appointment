using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCM.BL;
using System;

namespace OCM.BLTest
{
    [TestClass]
    public class AppointmentTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            var appointmentItem = new AppointmentItems
            {
                ServiceId = 1,
                CustomerId = 1
            };
            // Arrange
            var appointment = new Appointment();
            appointment.AppointmentItems.Add(appointmentItem);

            var expect = true;

            // Act
            var actual = appointment.Validate();

            // Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void ValidateInvalid()
        {
            
            // Arrange
            var appointment = new Appointment();

            var expect = false;

            // Act
            var actual = appointment.Validate();

            // Assert
            Assert.AreEqual(expect, actual);
        }
    }
}
