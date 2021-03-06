﻿// (c) Aleksey Nemiro, 2014
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nemiro.OAuth;
using System.Collections.Specialized;
using Nemiro.OAuth.Clients;
using System.Configuration;
using System.Text.RegularExpressions;
using Nemiro.OAuth.Extensions;

namespace Test.OAuthWeb.Controllers
{

  [OutputCache(Duration = 0, Location = System.Web.UI.OutputCacheLocation.None)]
  public partial class ApiController : Controller
  {
    
    /// <summary>
    /// Checks the test files for upload.
    /// </summary>
    private void InitTestFiles()
    {
      if (HttpContext.Cache["Nemiro.OAuth"] == null)
      {
        // cache is empty
        // get file for tests
        var r = OAuthUtility.Get("https://github.com/alekseynemiro/nemiro.oauth.dll/archive/master.zip");
        if (r.IsFile)
        {
          HttpContext.Cache.Add("Nemiro.OAuth", (byte[])r, null, DateTime.Now.AddDays(1), TimeSpan.Zero, System.Web.Caching.CacheItemPriority.Normal, null);
        }
      }
    }

  }

}