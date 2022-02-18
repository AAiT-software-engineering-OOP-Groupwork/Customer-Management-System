using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            string expected = "Baggins, Bilbo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };

            string expected = "Baggins";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "tade"
            };

            string expected = "tadese";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "chhala";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "josi";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "abel";
            Customer.InstanceCount += 1;

            //-- Act

            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
    public void ValidateValid()
    {
      //-- Arrange
      var customer = new Customer
      {
        LastName = "josi",
        EmailAddress = "yosi@gmail.com"
      };

      var expected = true;

      //-- Act
      var actual = customer.Validate();

      //-- Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ValidateMissingLastName()
    {
      //-- Arrange
      var customer = new Customer
      {
        EmailAddress = "yosi@gmail.com"
      };

      var expected = false;

      //-- Act
      var actual = customer.Validate();

      //-- Assert
      Assert.AreEqual(expected, actual);
    }

    }
}
