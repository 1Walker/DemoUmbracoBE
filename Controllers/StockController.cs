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
    /// This is a basic implementation of a list view which pulls data from a third party source.
    /// For demonstration purposes this just returns dummy data from inside the application
    /// </summary>
    public class StockController : SurfaceController
    {
        JavaScriptSerializer objSeralizer; 

        /// <summary>
        /// Returns a collection of stock items
        /// </summary>
        [HttpPost]
        public String GetCurrentStock()
        {
            // Fake response - this would be replaced with a request that is serialized into an object
            StockApiResponse objResponse = new StockApiResponse() {
                RequestId = Guid.NewGuid().ToString(),
                TimeStamp = DateTime.Now,

                Stock = new List<StockItem> {
                    new StockItem {
                        Name = "Product 1",
                        Description = "Placeholder description..",
                        ImageSrc = "../images/shoe.jpeg",
                        ExternalURL = "https://google.co.uk"
                    },
                    new StockItem {
                        Name = "Product 2",
                        Description = "Placeholder description..",
                        ImageSrc = "../images/shoe.jpeg",
                        ExternalURL = "https://google.co.uk"
                    },
                    new StockItem {
                        Name = "Product 3",
                        Description = "Placeholder description..",
                        ImageSrc = "../images/shoe.jpeg",
                        ExternalURL = "https://google.co.uk"
                    },
                    new StockItem {
                        Name = "Product 4",
                        Description = "Placeholder description..",
                        ImageSrc = "../images/shoe.jpeg",
                        ExternalURL = "https://google.co.uk"
                    },
                    new StockItem {
                        Name = "Product 5",
                        Description = "Placeholder description..",
                        ImageSrc = "../images/shoe.jpeg",
                        ExternalURL = "https://google.co.uk"
                    },
                    new StockItem {
                        Name = "Product 6",
                        Description = "Placeholder description..",
                        ImageSrc = "../images/shoe.jpeg",
                        ExternalURL = "https://google.co.uk"
                    },
                    new StockItem {
                        Name = "Product 7",
                        Description = "Placeholder description..",
                        ImageSrc = "../images/shoe.jpeg",
                        ExternalURL = "https://google.co.uk"
                    },
                    new StockItem {
                        Name = "Product 8",
                        Description = "Placeholder description..",
                        ImageSrc = "../images/shoe.jpeg",
                        ExternalURL = "https://google.co.uk"
                    },
                    new StockItem {
                        Name = "Product 9",
                        Description = "Placeholder description..",
                        ImageSrc = "../images/shoe.jpeg",
                        ExternalURL = "https://google.co.uk"
                    },
                    new StockItem {
                        Name = "Product 10",
                        Description = "Placeholder description..",
                        ImageSrc = "../images/shoe.jpeg",
                        ExternalURL = "https://google.co.uk"
                    },
                }
            }; 

            // Serialize & return object
            objSeralizer = new JavaScriptSerializer();
            return objSeralizer.Serialize(objResponse);
        }
    }
}