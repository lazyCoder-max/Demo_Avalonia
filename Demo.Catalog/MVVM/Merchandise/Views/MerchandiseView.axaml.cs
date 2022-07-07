using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Demo.Catalog.MVVM.Merchandise.ViewModels;

namespace Demo.Catalog.MVVM.Merchandise.Views
{
    public partial class MerchandiseView : UserControl
    {
        private MerchandiseViewModel? _viewModel;
        public MerchandiseView()
        {
            InitializeComponent();
            Initialized += MerchandiseView_Initialized;
        }

        private void MerchandiseView_Initialized(object? sender, System.EventArgs e)
        {
            _viewModel = DataContext as MerchandiseViewModel;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
