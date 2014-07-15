using System;

// 
// All exmaples are taken from MS Roslyn Codeplex page 
// https://www.codeplex.com/Download?ProjectName=roslyn&DownloadId=824694
// 

namespace CSharp6Samples_NullPropagation
{

  #region CSharp 5

  public class NullPropagationV5
  {
    public void MyMethod ()
    {
      var temp = GetCustomer ();
      string name = (temp == null) ? null : temp.Name;
    }

    private Customer GetCustomer ()
    {
      return null;
    }
  } 

  #endregion

  #region CSharp 6

  public class NullPropagationV6
  {
    public void MyMethod ()
    {
      var name = GetCustomer()?.Name;
    }

    private Customer GetCustomer ()
    {
      return null;
    }
  }

  #endregion

  public class Customer
  {
    public string Name { get; set; }
  }
}