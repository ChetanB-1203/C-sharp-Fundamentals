using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerManagement;

namespace CustomerManagementTests
{
    [TestClass]
    public class CustomerTest
    {
        
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FisrtName = "Chetan";
            customer.LastName = "Badgujar";

            string expected = "Badgujar Chetan";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ValidateMethod()
        {
            //Arrange
            var customer = new Customer
            {
                LastName = ""
            };

            var expected =false;

            //act
            var actual = customer.validate();

            //assert
            Assert.AreEqual(expected, actual);

        }

    }
}
