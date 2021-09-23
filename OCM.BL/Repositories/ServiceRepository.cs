using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL.Repositories
{
    public class ServiceRepository
    {
        /// <summary>
        /// Saves the service data
        /// </summary>
        /// <returns>True if data was successfully saved</returns>
        public bool Save()
        {
            // Code that saves the defined customer
            return true;
        }

        /// <summary>
        /// Retrieve the serive data by ID
        /// </summary>
        /// <param name="serviceId"></param>
        /// <returns>Service object wiht requested id</returns>
        public Service Retrieve(int serviceId)
        {
            // create instance of serivce
            // Pass in requested ID
            var service = new Service(serviceId);

            // Code that retrieves the defined service

            // Temporary hard-coded values to return
            // A populated service
            if (serviceId == 1)
            {
                service.TotalCost = 1.00M;
            }
            return service;
        }

        /// <summary>
        /// Retrieve List of serivce
        /// </summary>
        /// <returns>List of services</returns>
        public List<Service> Retrieve()
        {
            // Code that retieves list of services
            return new List<Service>();
        }
    }
}
