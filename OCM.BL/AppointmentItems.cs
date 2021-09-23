using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL
{
    public class AppointmentItems
    {
        public AppointmentItems() { }
        public AppointmentItems(int appointmentItemId) { AppointmentItemId = appointmentItemId; }

        public int AppointmentItemId { get; private set; }
        public DateTimeOffset? AppointmentDate { get; set; }
        public int? ServiceId { get; set; }
        public int? CustomerId { get; set; }

        public override string ToString() => $"{AppointmentDate.Value.Date} ({AppointmentItemId})";
        ///<summary>
        /// Validates the Appointment Item requirments
        ///</summary>
        ///<returns></returns>
        public bool Validate()
        {
            // requirements must be true in order to validate successfully
            var requirements = new List<bool>
            {
                AppointmentDate != null,
                ServiceId != null,
                CustomerId != null

            };

            var isValid = !requirements.Contains(false);
            return isValid;
        }
    }
}
