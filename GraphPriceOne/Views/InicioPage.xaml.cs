using CommunityToolkit.Mvvm.DependencyInjection;

using GraphPriceOne.ViewModels;

using Microsoft.UI.Xaml.Controls;

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
    }
}
