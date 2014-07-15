using System;
using System.Linq;

// 
// All exmaples are taken from MS Roslyn Codeplex page 
// https://www.codeplex.com/Download?ProjectName=roslyn&DownloadId=824694
// 

namespace CSharp6Samples_DeclarationExpressions
{

  #region CSharp 5

  public class DeclarationExpressionsV5
  {
    public void Method ()
    {
      // explicit declaration in extra line required
      int i;
      
      if (int.TryParse ("178965", out i))
      {
        int doubledI = i + i;
        Console.WriteLine ("{0} doubled is {1}", i, doubledI);
      }
    }
  }

  #endregion

  #region CSharp 6

  public class DeclarationExpressionsV6 
  {
    public void Method ()
    {
      if (int.TryParse ("178965", out int i))
      {
        int doubledI = i + i;
        Console.WriteLine ("{0} doubled is {1}", i, doubledI);
      } 
    
      // automatic type inferring is possible
      if (GetCoordinates (out var x, out var y))
      {
      }
    
      // x is no longer in scope here
      Console.WriteLine ("Result: {0}", (int x = GetValue()) * x); 
    
      object o = null;
      if ((string s = o as string) != null) 
      {
        Console.WriteLine (s);
      }

      // also useable with linq
      string[] source = null;
      var result = from s in source
                   select int.TryParse(s, out int i) ? i : -1;
    }

    private bool GetCoordinates (out int var1, out int var2)
    {
      throw new NotImplementedException ();
    }

    private int GetValue ()
    {
      throw new NotImplementedException ();
    }
  }

  #endregion
}