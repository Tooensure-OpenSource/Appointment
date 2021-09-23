using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL.Repositories
{
    public class ProductRepository
    {

        /// <summary>
        /// Saves the Product data
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined Product

            return true;
        }

        /// <summary>
        /// Retrieves the Product data
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            // create instance for product class
            // pass in requested ID
            var product = new Product(productId);

            // Code that retrieves the defined Product

            // Temporary hard-coded values to return
            // a populated customer
            if (productId == 1)
            {
                product.Name = "Cheese Burger";
                product.Description = "1 Bun, meat and cheese";
                product.CurrentPrice = 1.00M;
            }
            return product;
        }

        /// <summary>
        /// Retrieves all Products
        /// </summary>
        /// <returns></returns>
        public IList<Product> Retrieve()
        {
            // Code that retrieves the defined Product
            return new List<Product>();
        }
    }
}
