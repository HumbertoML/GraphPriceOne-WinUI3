using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Models
{
    public class TProducts
    {
        [PrimaryKey, Identity]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductURL { get; set; }
        public int UnitPriceTag { get; set; }
        public int UnitPriceDesc { get; set; }
        public int UnitPriceDescPorc { get; set; }
        public DateTime ProductTimePrice { get; set; }
        public int ShippingPrice { get; set; }
        public string StoreName { get; set; }
        public int UnitsInStock { get; set; }
    }
}
