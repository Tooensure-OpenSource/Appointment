using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL.Repositories
{
    public class CustomerRepository
    {
        /// <summary>
        /// Saves the customer data
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined customer

            return true;
        }

        /// <summary>
        /// Retrieves the customer data
        /// </summary>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // create the instance of the customer class
            // pass in the requested Id
            var customer = new Customer(customerId);

            // Code that retrieves the defined customer

            // Temporary hard-coded values to return
            // a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "tooensurellc@gmail.com";
                customer.FirstName = "Shawn";
                customer.LastName = "Doe";
            }

            return customer;
        }

        /// <summary>
        /// Retrieves all customers
        /// </summary>
        /// <returns></returns>
        public IList<Customer> Retrieve()
        {
            // Code that retrieves the defined customer
            return new List<Customer>();
        }
    }
}
