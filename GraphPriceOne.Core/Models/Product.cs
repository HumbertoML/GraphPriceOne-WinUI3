using System;
using System.Collections.Generic;

namespace GraphPriceOne.Core.Models
{
    public class Products
    {
        public long ProductID { get; set; }

        public string ProductName { get; set; }

        //precio normal
        public string UnitPriceTag { get; set; }

        //precio con descuento
        public string UnitPriceDesc { get; set; }

        public string UnitPriceDescPorc { get; set; }

        public DateTime ProductTimePrice { get; set; }

        // transporte gratis o de paga etc
        public double ShippingPrice { get; set; }
        public string UnitsInStock { get; set; }
        public string StoreName { get; set; }
    }
}
