using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL.Repositories
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve the Order data
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderId) {

            // create instance of Order class
            // pass in requested Id
            var order = new Order(orderId);

            /* code that retrieves the drfined order */

            // Temporary hard-coded values to return
            // a populated customer
            if (orderId == 1)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order; 
        }
        /// <summary>
        /// Saves the Order data
        /// </summary>
        /// <returns></returns>
        public bool Save() { /* code that saves the drfined order */ return true; }
    }
}
