using CustomerManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
    public  class AddressRepository
    {
       public List<Address> Retrieve(int customerId)
        {
            var addressList = new List<Address>();
            if (customerId == 1)
            {
                Address address = new Address(1)
                {
                    AddressType = 1,
                    Streetline = "Ramanand Nagar road",
                    City = "Jalgaon",
                    State = "Maharashatra",
                    Country = "India",
                    PostalCode = "425001"

                };
                addressList.Add(address);
                address = new Address(2)
                {
                    AddressType = 2,
                    Streetline = "Behind toyoto showroom",
                    City = "Pimpri-Chinchwad",
                    State = "Maharashatra",
                    Country = "India",
                    PostalCode = "411101"
                };
                addressList.Add(@address);
            }
            return addressList;
        }

        public bool save()
        {
            return true;    
        }
    }
}
