using System;
using Xunit;

namespace ACME.Tests
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
              FirstName = "Fat Bob",
              LastName = "NeJame"
            };
            string expected = "NeJame, Fat Bob";
            //-- Act
            string actual = customer.FullName;
            //-- Assert
            Assert.Equal(expected, actual);
        }
    }
}
