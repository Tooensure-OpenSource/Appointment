using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL
{
    public class ServiceItem : EntityBase
    {
        /// <summary>
        /// Create service instance
        /// </summary>
        public ServiceItem() { }
        /// <summary>
        /// Create service item instance and attach ID  
        /// </summary>
        /// <param name="serviceItemId"></param>
        public ServiceItem(int serviceItemId)
        {
            ServiceItemId = serviceItemId;
        }
        public int ServiceItemId { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Cost { get; set; }

        public override string ToString() => Name;
        /// <summary>
        /// Validate service item data
        /// </summary>
        /// <returns>Reture if all requriments are meet</returns>
        public override bool Validate()
        {
            // All requirments must return true in order to validate successfully
            var requirments = new List<bool>
            {
                !string.IsNullOrWhiteSpace(Name),
                !string.IsNullOrWhiteSpace(Description),
                Cost != null
            };
            // Searches required list checks for false flags
            var isValid = !requirments.Contains(false);
            return isValid;
        }
    }
}
