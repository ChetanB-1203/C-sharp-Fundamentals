using ClassLibrary1.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerManagement;

namespace CustomerManagementTests
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Arrange
            ProductRepository productRepo = new ProductRepository();

            var expected = new Product(45)
            {
                CurrentPrice = 100,
                ProductName = "Painting",
                ProductDescription = "painting about  nature"
            };

            //act
            var actual = productRepo.Retrieve(45);

            //assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);


        }
    }
}
