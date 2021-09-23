using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL.Repositories
{
    public class ServiceItemRepository
    {
        /// <summary>
        /// Save service item data
        /// </summary>
        /// <returns>True if service item was successfully saved</returns>
        public bool Save(ServiceItem serviceItem)
        {

            // requriments items must return true in order to save successfully
            var requriments = new List<bool>
            {
                serviceItem.HasChanges,
                serviceItem.IsValid,
                serviceItem.IsNew

            };
            // One false flage will trigger success false
            var success = !requriments.Contains(false);
            // Success operations
            if (success)
            {
                // Call an Insert Stroed Precedure
            } else
            {
                // Call an Updated Stored precedure
            }

            // Code that saves the defined service item
            return success;
        }

        /// <summary>
        /// Retrieve requested service item data
        /// </summary>
        /// <param name="serviceItemId"></param>
        /// <returns>Service Item containing requested ID</returns>
        public ServiceItem Retrieve(int serviceItemId)
        {
            // Create service item instance
            // Pass in requested Id
            var serviceItem = new ServiceItem(serviceItemId);

            // Code the retrieves required service item data

            // Temporary hard-coded values to return
            // A populated service item
            if (serviceItemId == 1)
            {
                serviceItem.Name = "Basic hairline Cut";
                serviceItem.Description = "Clean front, back and side cut";
                serviceItem.Cost = 10.00M;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object : {myObject.ToString()}");
            Console.WriteLine($"Appointment : {serviceItem.ToString()}");
            return serviceItem;
        }

        /// <summary>
        /// Retrieve service item data
        /// </summary>
        /// <returns>A list of serive items</returns>
        public List<ServiceItem> Retrieve()
        {
            return new List<ServiceItem>();
        }
    }
}
