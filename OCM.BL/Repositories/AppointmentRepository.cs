using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL.Repositories
{
    public class AppointmentRepository
    {
        /// <summary>
        /// Saves the Appointment data
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined Appointment

            return true;
        }

        /// <summary>
        /// Retrieves the Appointment data
        /// </summary>
        /// <returns></returns>
        public Appointment Retrieve(int appointmentId)
        {
            // create the instance of the Appointment class
            // pass in the requested Id
            var appointment = new Appointment(appointmentId);

            // Code that retrieves the defined Appointment

            // Temporary hard-coded values to return
            // a populated Appointment
            var appointmentItem = new AppointmentItems
            {
                ServiceId = 1,
                CustomerId = 1
            };
            if (appointmentId == 1)
            {
                appointment.AppointmentItems.Add(appointmentItem);
            }
           
            return appointment;
        }

        /// <summary>
        /// Retrieves all Appointments
        /// </summary>
        /// <returns></returns>
        public IList<Appointment> Retrieve()
        {
            // Code that retrieves the defined Appointment
            return new List<Appointment>();
        }
    }
}
