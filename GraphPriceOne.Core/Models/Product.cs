using System;
using System.Collections.Generic;

namespace GraphPriceOne.Core.Models
{
    public class Product
    {
        public long ProductID { get; set; }

        public string ProductName { get; set; }

        //precio normal
        public string PriceTag { get; set; }

        //precio con descuento
        public string PriceDesc { get; set; }

        public string PriceDescPorc { get; set; }

        public DateTime ProductTimePrice { get; set; }

        // transporte gratis o de paga etc
        public double ShippingPrice { get; set; }

        public string Store { get; set; }
    }
}
