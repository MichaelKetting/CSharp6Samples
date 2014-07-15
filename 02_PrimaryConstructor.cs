using System;

 // 
 // All exmaples are taken from MS Roslyn Codeplex page 
 // https://www.codeplex.com/Download?ProjectName=roslyn&DownloadId=824694
 // 

namespace CSharp6Samples_PrimaryConstructor
{

  #region CSharp 5

  public class CustomerV5
  {
    private string firstName;
    private string lastName;

    public CustomerV5 (string firstName, string lastName)
    {
      this.firstName = firstName;
      this.lastName = lastName;
    }

    public string FirstName
    {
      get { return firstName; }
    }

    public string LastName
    {
      get { return lastName; }
    }
  }

  #endregion

  #region CSharp 6

  public class CustomerV6 (string firstName, string lastName)
  {
    public string First { get; } = ArgumentUtility.CheckNotNull (firstName, "firstName"); 
    public string Last { get; }  = ArgumentUtility.CheckNotNull (lastName, "lastName"); 

    // a private field birthday is created and initialized with the value of paramter birthday

    public CustomerV6 () : this ("Jane", "Doe")
    {
      // all other ctors must call the primary one
    }
  }

  public static class ArgumentUtility
  {
    public static T CheckNotNull<T> (T value, string parameterName)
    {
      if ( value== null)
        throw new ArgumentNullException (parameterName);
      return value;
    }
  }

  #endregion
}