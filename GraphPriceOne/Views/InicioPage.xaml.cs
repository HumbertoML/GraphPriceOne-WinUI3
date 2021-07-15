using CommunityToolkit.Mvvm.DependencyInjection;
using GraphPriceOne.ViewModels;
using Microsoft.UI.Xaml.Controls;
using HtmlAgilityPack;
using Windows.ApplicationModel.DataTransfer;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using Microsoft.UI.Xaml;

namespace GraphPriceOne.Views
{
    public sealed partial class InicioPage : Page
    {
        public InicioViewModel ViewModel { get; }

        public InicioPage()
        {
            ViewModel = Ioc.Default.GetService<InicioViewModel>();
            InitializeComponent();
        }
        const string titleNode = "//h1[@class='ui-pdp-title']";
        const string titleNode1 = "//span[@id='productTitle']";

        const string priceNodeV1 = "//span[@class='price-tag-fraction']";
        const string priceNodeV2 = "//span[@id='priceblock_ourprice']";
        const string priceNodeV3 = "//span[@id='priceblock_saleprice']";
        const string error = "Error: No ha seleccionado un selector para esta pagina";
        const string errorTitle = "Error";
        public static async Task<string> OutputClipboardText()
        {
            DataPackageView dataPackageView = Clipboard.GetContent();

            if (dataPackageView.Contains(StandardDataFormats.Text))
            {
                string text = await dataPackageView.GetTextAsync();
                return text;
            }
            return await Task.FromResult(String.Empty);
        }
        private async void DetectarUrlValidaClipboard()
        {
            string url = await OutputClipboardText();
            //detecta que la url es valida y lanza el dialogo de confirmacion
            if (Uri.IsWellFormedUriString(url, UriKind.Absolute) && url != TxtUrl.Text)
            {
                //FetchPrice.Focus(FocusState.Programmatic);
            }
        }
        public async void validarDatos()
        {
            // Create an HttpClientHandler object and set to use default credentials
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;

            // Create an HttpClient object
            HttpClient httpClient = new HttpClient(handler);
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(TxtUrl.Text);
                HttpContent content = response.Content;
                HtmlDocument document = new HtmlDocument();
                document.LoadHtml(await content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", ex.Message);
            }
            handler.Dispose();
            httpClient.Dispose();
        }

        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        static readonly HttpClient client = new HttpClient();
        public async void ObtenerDatos()
        {
            try
            {
                Progress.IsActive = true;
                Price.Text = "";
                Title.Text = "";
                Price.FontSize = 204;
                string URLTexto = TxtUrl.Text;
                HttpResponseMessage response = await client.GetAsync(URLTexto);
                HttpContent content = response.Content;
                HtmlDocument document = new HtmlDocument();
                document.LoadHtml(await content.ReadAsStringAsync());

                Task.WaitAll();
                // Get Title
                var title = document.DocumentNode.SelectSingleNode(titleNode);
                var title1 = document.DocumentNode.SelectSingleNode(titleNode1);
                // Get and Show Price
                var price = document.DocumentNode.SelectSingleNode(priceNodeV1);
                Progress.IsActive = false;
                if (price == null)
                    price = document.DocumentNode.SelectSingleNode(priceNodeV2);
                // Show Title and Price
                if (price == null)
                    price = document.DocumentNode.SelectSingleNode(priceNodeV3);
                // Show Title and Price
                if (title != null)
                    Title.Text = HttpUtility.HtmlDecode(title.InnerText).Trim();
                else if (title != null)
                {
                    Title.Text = HttpUtility.HtmlDecode(title1.InnerText).Trim();
                }
                else
                    Title.Text = errorTitle;
                if (price != null)
                    Price.Text = price.InnerText;
                else
                    Title.Text = error;
            }
            catch (Exception ex)
            {
                Progress.IsActive = false;
                Title.Text = "Porfavor agregue una url valida";
                Price.FontSize = 16;
                Price.Text = ex.ToString() + "\n";
            }
        }
        private void FetchPrice_Click(object sender, RoutedEventArgs e)
        {
            ObtenerDatos();
        }
        private void AmazonURL_PointerEntered(object sender, RoutedEventArgs e)
        {
            DetectarUrlValidaClipboard();
        }
    }
}
