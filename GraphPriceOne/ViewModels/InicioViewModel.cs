/*
using CommunityToolkit.Mvvm.ComponentModel;
using Connection;
using GraphPriceOne.Library;
using GraphPriceOne.Models;
using LinqToDB;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GraphPriceOne.ViewModels
{
    public class InicioViewModel : ProductModels
    {

        const string titleNode = "//h1[@class='ui-pdp-title']";
        const string titleNode1 = "//span[@id='productTitle']";

        const string priceNodeV1 = "//span[@class='price-tag-fraction']";
        const string priceNodeV2 = "//span[@id='priceblock_ourprice']";
        const string priceNodeV3 = "//span[@id='priceblock_saleprice']";
        const string error = "Error: No ha seleccionado un selector para esta pagina";
        const string errorTitle = "Error";

        private ICommand _command;

        public SqlConnection connection = new SqlConnection();
        private TextBox _TexBoxUrl;
        private Connections _conn;

        public InicioViewModel(object[] campos)
        {
            //_bitmapImage = new BitmapImage();
            //_uploadImage = new UploadImage();
            _TexBoxUrl = (TextBox)campos[0];
            _conn = new Connections();
        }

        public ICommand AddUrl
        {
            get
            {
                return _command ?? (_command = new CommandHandler(async () =>
                {
                    await ObtenerDatos();
                }));
            }
        }

        private async Task ObtenerDatos()
        {
            try
            {

                var products = _conn.Products.Where(u => u.ProductID.Equals(1)).ToList();
                var addProduct = products.ElementAt(0);

                //addProduct.ProductName = "hola";
                //addProduct.ProductURL = "facebook.com";

                _conn.Products.Value(u => u.ProductURL, TxtUrl).Insert();
                //Title.Text = _conn.Products.ElementAt(1).ProductName.ToString();
                TxtUrl = _conn.Products.ElementAt(1).ProductURL.ToString();
                var cantRegistros = _conn.Products.ToList().Count;
                string productosLista = "";

                for (int i = 0; i <= cantRegistros - 1; i++)
                {
                    productosLista += _conn.Products.ElementAt(i).ProductName.ToString() + "\n";
                }
                TxtUrl = productosLista;
                //ObtenerDatos();
            }
            catch (SqlException ex)
            {
                TxtUrl = ex.ToString();
                //txtStatus.Text = ex.ToString();
            }
        }
    }
}
*/


using CommunityToolkit.Mvvm.ComponentModel;
using Connection;
using GraphPriceOne.Library;
using GraphPriceOne.Models;
using LinqToDB;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GraphPriceOne.ViewModels
{
    public class InicioViewModel : ObservableRecipient
    {

        public InicioViewModel()
        {

        }
    }

}