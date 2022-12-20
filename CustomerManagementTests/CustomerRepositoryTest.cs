using CustomerManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;

namespace CustomerManagementTests
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //arrange
            var customerRepo = new CustomerRepository();
            var expected = new Customer(1)
            {
                FisrtName = "Chetan",
                LastName = "Badgujar",
                EmailAddress = "chetanbadgujar1203@gmail.com",
                AddressList = new List<Address>()
                {

                    new Address(1)
                    {
                        AddressType = 1,
                        Streetline = "Ramanand Nagar road",
                        City = "Jalgaon",
                        State = "Maharashatra",
                        Country = "India",
                        PostalCode = "425001"

                    },

                    new Address(2)
                    {
                        AddressType = 2,
                        Streetline = "Behind toyoto showroom",
                        City = "Pimpri-Chinchwad",
                        State = "Maharashatra",
                        Country = "India",
                        PostalCode = "411101"
                    }
                }
            };

        
               
            

            //act
            var actual = customerRepo.Retrieve(1);

            //assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FisrtName, actual.FisrtName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for(int i =0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].Streetline, actual.AddressList[i].Streetline);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
            }
        }

    }
}
