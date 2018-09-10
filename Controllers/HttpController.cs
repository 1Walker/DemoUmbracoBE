using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Umbraco;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Umbraco.Core.Models;
using System.Web.Script.Serialization;
using Site.Models.Backend;
using System.Net;

namespace Site.Controllers
{
    /// <summary>
    /// Surface Controller to manage Umbraco dashboard content and features 
    /// </summary>
    public class HttpController : SurfaceController
    {
        /// <summary>
        /// Makes a request to a url and returns its status code
        /// </summary>
        [HttpPost]
        public Int32 GetWebsiteStatusCode(String url)
        {
            try
            {
                // Configure webrequest
                HttpWebRequest objWebRequest = WebRequest.Create(url) as HttpWebRequest;
                objWebRequest.Method = "GET";

                using (HttpWebResponse objResponse = objWebRequest.GetResponse() as HttpWebResponse)
                {
                    if (objResponse != null)
                    {
                        return (Int32)objResponse.StatusCode;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception objErr)
            {
                return -1;
            }
        }
    }
}