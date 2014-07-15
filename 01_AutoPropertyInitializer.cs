using System;

 // 
 // All exmaples are taken from MS Roslyn Codeplex page 
 // https://www.codeplex.com/Download?ProjectName=roslyn&DownloadId=824694
 // 

namespace CSharp6Samples_AutoPropertyInitializer
{
  #region CSharp 5

  public class CustomerV5
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }


    public CustomerV5 ()
    {
      FirstName = "Jane";
      LastName = "Doe";
    }
  }

  #endregion

  #region CSharp 6

  public class CustomerV6
  {
    public string FirstName { get; set; }  = "Jane";
    
    // getter only is possible in combination with an initial value
    public string LastName { get; } = "Doe";
  }

  #endregion
}