using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.BL
{
    public class Address
    {
        public Address() { }
        public Address(int addressId) { AddressId = addressId; }


        public int AddressId { get; private set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int? PostalCode { get; set; }
        public string AddressType { get; set; }

        public bool CheckStreetLine
        {
            get
            {
                return !string.IsNullOrWhiteSpace(StreetLine1);
            }
        }
        public bool Validate()
        {
            // requirements must be true in order to validate successfully
            var requirements = new List<bool>
            {
                !string.IsNullOrWhiteSpace(StreetLine1),
                !string.IsNullOrWhiteSpace(StreetLine1),
                !string.IsNullOrWhiteSpace(City),
                !string.IsNullOrWhiteSpace(State),
                !string.IsNullOrWhiteSpace(Country),
                !string.IsNullOrWhiteSpace(AddressType),
                PostalCode != null
            };

            var isValid = !requirements.Contains(false);

            return isValid;
        }

    }
}
