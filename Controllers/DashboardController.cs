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

namespace Site.Controllers
{
    /// <summary>
    /// Surface Controller to manage Umbraco dashboard content and features 
    /// </summary>
    public class DashboardController : SurfaceController
    {
        JavaScriptSerializer objSeralizer; 

        /// <summary>
        /// For demo purposes, a simple endpoint has been created to return some content
        /// </summary>
        [HttpPost]
        public String GetIntroDashboard()
        {
            // Usually, there would be no need to serve templates from within the same website.
            // For this program, an umbraco node has been created to template the dashboard content
            IPublishedContent objDashboardPage = Umbraco.TypedContent(1066);
            
            if(objDashboardPage != null)
            {
                IntroDashboard objDashboard = new IntroDashboard() {
                    HeaderImageUri = "http://localhost:60659/images/BrandExpLogo.svg",
                    Title = objDashboardPage.GetPropertyValue<String>("title"),
                    ContentBody = objDashboardPage.GetPropertyValue<String>("body"),
                    StyleSheetUri = "http://localhost:60659/css/Rich%20Text%20Editor.css"
                };

                // Serialize & return object
                objSeralizer = new JavaScriptSerializer();
                return objSeralizer.Serialize(objDashboard);
            }
            else
            {
                return null;
            }
        }
    }
}