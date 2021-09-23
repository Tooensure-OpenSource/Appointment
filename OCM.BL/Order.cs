using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL
{
    public class Order
    {
        public Order() { }
        public Order(int orderId) { OrderId = orderId; }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        /// <summary>
        /// Order the Order data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            /* code that retrieves the drfined order */
            var isValid = OrderDate == null ? false : true;
            return isValid;
        }
        
    }
}
