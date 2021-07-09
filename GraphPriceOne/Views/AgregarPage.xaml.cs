using CommunityToolkit.Mvvm.DependencyInjection;

using GraphPriceOne.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace GraphPriceOne.Views
{
    public sealed partial class AgregarPage : Page
    {
        public AgregarViewModel ViewModel { get; }

        public AgregarPage()
        {
            ViewModel = Ioc.Default.GetService<AgregarViewModel>();
            InitializeComponent();
        }
    }
}
