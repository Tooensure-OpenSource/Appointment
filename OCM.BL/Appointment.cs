using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL
{
    public class Appointment
    {
        public Appointment() : this(0) { }

        public Appointment(int appointmentId) { 
            AppointmentId = appointmentId;
            AppointmentItems = new List<AppointmentItems>(); 
        }

        public int AppointmentId { get; private set; }
        public List<AppointmentItems> AppointmentItems { get; set; }
        public int BusinessId { get; set; }

        /// <summary>
        /// Order the Order data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            // requirements must be true in order to validate successfully
            var requirements = new List<bool>
            {
                AppointmentItems.Count() >= 1,
            };

            var isValid = !requirements.Contains(false);

            return isValid;
        }
    }
}
