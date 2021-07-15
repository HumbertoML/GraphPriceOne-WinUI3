using GraphPriceOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Email;

namespace GraphPriceOne.Models
{
    public class ProductModels : PropertyChangedNotification
    {
        public int ID { get; set; }
        public string TxtUrl
        {
            get { return GetValue(() => TxtUrl); }
            set
            {
                SetValue(() => TxtUrl, value);
            }
        }
    }
}
