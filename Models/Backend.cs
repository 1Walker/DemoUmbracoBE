using System;
using Umbraco;
using Umbraco.Core;

namespace Site.Models.Backend {

    /// <summary>
    /// Data relating to the intro dashboard 
    /// </summary>
    public class IntroDashboard {

        public String Title { get; set; }

        public String ContentBody { get; set; }

        public String HeaderImageUri { get; set; }

        public String StyleSheetUri { get; set; }
    }
}
