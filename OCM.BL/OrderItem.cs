using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL
{
    public class OrderItem
    {
        public OrderItem() { }
        public OrderItem(int orderId) { }

        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; private set; }
        public int ProductId { get; set; }


        /// <summary>
        /// Validates the OrderItem data
        /// </summary>
        /// <returns></returns>
        public bool Validate() 
        {
            var isValid = Quantity <= 0 || ProductId <= 0 || PurchasePrice == null ? false : true;
            return isValid; 
        }

        /// <summary>
        /// Saves the OrderItem data
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined OrderItem

            return true;
        }

        /// <summary>
        /// Retrieves the OrderItem data
        /// </summary>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            // Code that retrieves the defined OrderItem
            return new OrderItem();
        }

        /// <summary>
        /// Retrieves all OrderItem
        /// </summary>
        /// <returns></returns>
        public IList<OrderItem> Retrieve()
        {
            // Code that retrieves the defined OrderItem
            return new List<OrderItem>();
        }
    }
}
