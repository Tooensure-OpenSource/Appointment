using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCM.BL;
using OCM.BL.Repositories;
using System;

namespace OCM.BLTest.RepositoryTest
{
    [TestClass]
    public class AppointmentRepositoryTest
    {
        [TestMethod]
        public void RetrieveAppointment()
        {
            // Arrange
            var appointment = new AppointmentRepository();
            var expect = new Appointment(1);

            // Act
            var actual = appointment.Retrieve(1);
            //var node2 = actual.AppointmentItems;


            // Assert
            Assert.AreEqual(expect.AppointmentId, actual.AppointmentId);
            // thus was only testing logic and may be commented out

           
        }
    }
}
