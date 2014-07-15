using System;

 // 
 // All exmaples are taken from MS Roslyn Codeplex page 
 // https://www.codeplex.com/Download?ProjectName=roslyn&DownloadId=824694
 // 

namespace CSharp6Samples_ExceptionFilters
{

  #region CSharp 5

  public class ExceptionFiltersV5
  {
    public void Method ()
    {
      try 
      {
        // do it 
      }
      catch (Exception e)
      {
        if (MyFilterCondition (e))
        {
          // process exception
        }
        else
        {
          throw;
        }
      }
    }

    private bool MyFilterCondition (Exception e)
    {
      throw new NotImplementedException ();
    }
  }

  #endregion

  #region CSharp 6

  public class ExceptionFiltersV6 
  {
    public void Method ()
    {
      try 
      {
        // do it 
      }
      catch (Exception e) if (MyFilterCondition(e)) 
      { 
        // only caught if MyFilterCondition is true
        // if not filtered, stack is unharmed, exception keeps going
      }
    }

    private bool MyFilterCondition (Exception e)
    {
      throw new NotImplementedException ();
    }
  }

  #endregion
}