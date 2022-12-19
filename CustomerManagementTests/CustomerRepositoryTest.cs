using CustomerManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
                EmailAddress = "chetanbadgujar1203@gmail.com"
            };

            //act
            var actual = customerRepo.Retrieve(1);

            //assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FisrtName, actual.FisrtName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

    }
}
