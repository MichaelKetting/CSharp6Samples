using System;
using System.Threading.Tasks;

// 
// All exmaples are taken from MS Roslyn Codeplex page 
// https://www.codeplex.com/Download?ProjectName=roslyn&DownloadId=824694
// 

namespace CSharp6Samples_AwaitCatchFinally
{

  #region CSharp 5 Not possible 

  public class AwaitCatchFinallyV5
  {
    private async void Method ()
    {
      Resource res = null;

      try
      {
        res = await Resource.OpenAsync ();
      }
      catch (Exception e)
      {
        var task = Resource.LogAsync (res, e);
        task.Wait();
      }
      finally
      {
        var task = res.CloseAsync ();
        task.Wait ();
      }
    }
  }
  #endregion

  #region CSharp 6

  public class AwaitCatchFinallyV6 
  {
    private async void Method () 
    {
      Resource res = null;
     
      try
      { 
        res = await Resource.OpenAsync (); 
      }
      catch (Exception e) 
      { 
        await Resource.LogAsync (res, e); 
      } 
      finally
      { 
        if (res != null) await res.CloseAsync (); 
      }
    }
  }

  #endregion

  public class Resource
  {
    internal static Task<Resource> OpenAsync ()
    {
      throw new NotImplementedException ();
    }

    internal static Task LogAsync (Resource res, Exception e)
    {
      throw new NotImplementedException ();
    }

    internal Task CloseAsync ()
    {
      throw new NotImplementedException ();
    }
  }
}