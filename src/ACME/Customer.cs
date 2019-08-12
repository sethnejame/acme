using System;

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
  }

}
