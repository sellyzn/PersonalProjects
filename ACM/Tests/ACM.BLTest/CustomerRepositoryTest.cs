using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAdress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                Lastname = "Baggins"
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            //Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.Lastname, actual.Lastname);
        }
    }
}
