using System;
using System.Collections.Generic;

// 
// All exmaples are taken from MS Roslyn Codeplex page 
// https://www.codeplex.com/Download?ProjectName=roslyn&DownloadId=824694
// 

namespace CSharp6Samples_DictionaryInitializer
{

  #region CSharp 5

  public class DictionaryInitializerV5
  {
    private void Method ()
    {

      var numbers = new Dictionary<int, string> 
      { 
         { 7, "seven" }, 
         { 13, "thirteen" }, 
         { 9, "nine" } 
      };

      var names = new Dictionary<string, string> 
      { 
         {"me", "Luke"}, 
         {"you", "Leia"}, 
         {"father", "Lord Vader"}
      };
    }
  }

  #endregion

  #region CSharp 6

  public class DictionaryInitializerV6 
  {
    private void Method() {
    
      var numbers = new Dictionary<int, string> 
      { 
         [7] = "seven", 
         [9] = "nine", 
         [13] = "thirteen"
      };

      var names = new Dictionary<string, string> 
      { 
         ["me"] = "Luke", 
         ["you"] = "Leia", 
         ["father"] = "Lord Vader"
      };
    }
  }

  #endregion
}