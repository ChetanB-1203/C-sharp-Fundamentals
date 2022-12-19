using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerManagement;
using ClassLibrary1.Repository;

namespace CustomerManagementTests
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void ValidRetrieve()
        {
            //Arrange
            var orderRepo = new OrderRepository();

            var expected = new Order(7)
            {
                OrderDate = DateTime.Now,
            };

            //Act
            var actual = orderRepo.Retrieve(7);

            //assert
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            //Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
