using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Demo.Catalog.MVVM.Merchandise.ViewModels;

namespace Demo.Catalog.MVVM.Merchandise.Views
{
    public partial class MerchandiseWindow : Window
    {
        private MerchandiseWindowViewModel? _viewModel;
        public MerchandiseWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            Opened += MerchandiseWindow_Opened;
        }
        public MerchandiseWindow(MerchandiseWindowViewModel viewModel)
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            _viewModel = viewModel;
            DataContext = _viewModel;
        }

        private void MerchandiseWindow_Opened(object? sender, System.EventArgs e)
        {
            _viewModel = new MerchandiseWindowViewModel();
            DataContext = _viewModel;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            _viewModel?.OpenFileDialog(this);
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
