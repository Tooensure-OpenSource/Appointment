using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL
{
    public class Product
    {
        public Product() { }
        public Product( int productId ) { ProductId = productId; }

        public int ProductId { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }
        public IList<string> Images { get; set; }


        public string ProductItem
        {
            get { return Validate() ? $"{Name} - {CurrentPrice}" : "Invalid Product"; }
        }

        /// <summary>
        /// Validates the Product data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            bool reqiureName = !string.IsNullOrWhiteSpace(Name);

            if (!reqiureName) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

    }
}
