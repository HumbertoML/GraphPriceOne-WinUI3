using System;
using System.Collections.Generic;

namespace GraphPriceOne.Core.Models
{
    // Remove this class once your pages/features are using your data.
    // This is used by the SampleDataService.
    // It is the model class we use to display data on pages like Grid, Chart, and ListDetails.
    public class Store
    {
        public string StoreID { get; set; }

        public string StoreName { get; set; }

        public ICollection<SampleOrder> Orders { get; set; }
    }
}
