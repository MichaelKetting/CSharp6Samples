
 // 
 // All exmaples are taken from MS Roslyn Codeplex page 
 // https://www.codeplex.com/Download?ProjectName=roslyn&DownloadId=824694
 // 

namespace CSharp6Samples_UsingStatic
{

  #region SimpleMethods CSharp 5
  namespace CSharp6Samples_UsingStatic.CS5
  {
    using System;
  
    class ProgramV5a
    { 
      static void Main() 
      {
        Console.WriteLine (Math.Sqrt (3*3 + 4*4));
      }
    }
  }
  #endregion

  #region SimpleMethodsCSharp 6

  namespace CSharp6Samples_UsingStatic.CS6
  {
    using System.Console; 
    using System.Math;
  
    class ProgramV6a
    {
      static void Main()
      {
        WriteLine (Sqrt (3*3 + 4*4));
      }
    }
  }
  #endregion
}