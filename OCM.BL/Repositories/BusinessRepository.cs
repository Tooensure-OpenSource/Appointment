using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL.Repositories
{
    public class BusinessRepository
    {
        /// <summary>
        /// Save the business data
        /// </summary>
        /// <returns>True when business is successfully saved</returns>
        public bool Save()
        {
            // Code that saves the defined customer
            return true;
        }
        /// <summary>
        /// Retrieve selected business 
        /// </summary>
        /// <param name="businessId"></param>
        /// <returns>A business with requested id</returns>
        public Business Retrieve(int businessId)
        {
            // create instance on business
            // pass in requested Id
            var business = new Business(businessId);

            // code that retrieves the defined business

            // Temporary hard-coded values to return
            // A populated business
            if (businessId == 1)
            {
                business.Name = "Tooensure LLC";
            }

            return business;


        }

        /// <summary>
        /// Retrieve business data
        /// </summary>
        /// <returns></returns>
        public List<Business> Retrieve()
        {
            return new List<Business>();
        }
    }
}
