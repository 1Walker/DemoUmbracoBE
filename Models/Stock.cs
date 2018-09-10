using System;
using System.Collections.Generic;
using Umbraco;
using Umbraco.Core;

namespace Site.Models.Backend {

    /// <summary>
    /// An example wrapper of what the stock system may return.
    /// The data from this model will in this case be serialized from a JSON response
    /// </summary>
    public class StockApiResponse
    {
        /// <summary>
        /// A timestamp of when this response was provided
        /// </summary>
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// An ID for this request to (GUID)
        /// </summary>
        public String RequestId { get; set; }

        /// <summary>
        /// An array that may contain a collection of stock items
        /// </summary>
        public List<StockItem> Stock { get; set; }
    }

    /// <summary>
    /// A model of all data relating to a stock item
    /// </summary>
    public class StockItem
    {
        /// <summary>
        /// The name of the product
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// A short description for this product
        /// </summary>
        public String Description { get; set; }

        public String ImageSrc { get; set; }

        /// <summary>
        /// Where the product will direct the user
        /// </summary>
        public String ExternalURL { get; set; }
    }
}
