using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL
{
    public class Business : User
    {
        public Business() : this(0) { }
        public Business(int businessId)
        {
            BusinessId = businessId;
            Services = new List<Service>();
        }

        public int BusinessId { get; private set; }
        public string Name { get; set; }
        public IList<Service> Services { get; set; }

        /// <summary>
        ///  Validate required data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            // Requirments must return true in order to Validate successfully
            var requirments = new List<bool>
            {
                !string.IsNullOrWhiteSpace(Name)
            };
            // Searches required list checks for false flags
            var isValid = !requirments.Contains(false); 

            return isValid;
        }
    }
}
