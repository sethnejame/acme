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

    [Fact]
    public void FullNameFirstNameEmpty()
    {
      //-- Arrange
      Customer customer = new Customer
      {
        LastName = "NeJame"
      };
      string expected = "NeJame";
      //-- Act
      string actual = customer.FullName;
      //-- Assert
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void FullNameLastNameEmpty()
    {
      //-- Arrange
      Customer customer = new Customer
      {
        FirstName = "Fat Bob"
      };
      string expected = "Fat Bob";
      //-- Act
      string actual = customer.FullName;
      //-- Assert
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void StaticTest()
    {
      //-- Arrange
      var c1 = new Customer();
      c1.FirstName = "Seth";
      Customer.InstanceCount += 1;

      var c2 = new Customer();
      c2.FirstName = "Natalie";
      Customer.InstanceCount += 1;

      var c3 = new Customer();
      c3.FirstName = "Fat Bob";
      Customer.InstanceCount += 1;

      //-- Act

      //-- Assert
      Assert.Equal(3, Customer.InstanceCount);
    }
  }
}
