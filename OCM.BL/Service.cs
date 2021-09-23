using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL
{
    public class Service : EntityBase
    {
        /// <summary>
        /// Create service instance
        /// </summary>
        public Service() : this(0) { }
        /// <summary>
        /// Create service instance and asigns service Id
        /// </summary>
        /// <param name="serviceId"></param>
        public Service(int serviceId)
        {
            ServiceId = serviceId;
            ServiceItems = new List<ServiceItem>();
        }

        public int ServiceId { get; private set; }
        public decimal? TotalCost { get; set; }
        public List<ServiceItem> ServiceItems { get; set; }

        /// <summary>
        /// Validate service requirments
        /// </summary>
        /// <returns>True if all requirments or meet</returns>
        public override bool Validate()
        {
            // All requirments must return true in order to validate successful
            var requirments = new List<bool>
            {
                TotalCost != null
            };
            // Searches required list checks for false flags
            var isValid = !requirments.Contains(false);
            return isValid;
        }
    }
}
