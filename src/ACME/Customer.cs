using System;
using System.Collections.Generic;

namespace ACME
{
  public class Customer
  {
    // the DB will set the ID automatically
    public int CustomerId { get; private set; }

    public string Email { get; set; }
    // set/get methods and backing field all in one
    public string FirstName { get; set; }
    // this is a backing field for the prop declared in LastName
    private string _lastName;
    // the prop below is stored in the backing field above via the get/set accessors
    public string LastName
    {
      get
      {
        return _lastName;
      }
      set
      {
        _lastName = value;
      }
    }

    public string FullName
    {
      get
      {
        string fullName = LastName;
        if (!string.IsNullOrWhiteSpace(FirstName))
        {
          if (!string.IsNullOrWhiteSpace(fullName))
          {
            fullName += ", ";
          }
          fullName += FirstName;
        }
        return fullName;
      }
    }
    // using a static modifier on the class member below makes this
    // member belong to the class itself, rather than an instance of the object
    // This is useful for holding information relative to all
    // objects made from the 'Customer' class
    public static int InstanceCount { get; set; }
    // Retrieves one customer
    public Customer Retrieve(int customerId)
    {
      // Code that retrieves the defined customer

      return new Customer();
    }

    // Retrieve all customers
    public List<Customer> Retrieve()
    {
      // Code that retrieves all of the customers

      return new List<Customer>();
    }

    // Saves the current customer
    public bool Save()
    {
      // Code that saves the defined customer
      return true;
    }

    // Validates a field
    public bool Validate()
    {
      var isValid = true;

      if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
      if (string.IsNullOrWhiteSpace(Email)) isValid = false;

      return isValid;
    }
  }

}
