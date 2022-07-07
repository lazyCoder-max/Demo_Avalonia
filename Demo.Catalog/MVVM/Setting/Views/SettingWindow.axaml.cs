using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Demo.Catalog.MVVM.Setting.ViewModels;

namespace Demo.Catalog.MVVM.Setting.Views
{
    public partial class SettingWindow : Window
    {
        private SettingWindowViewModel? _viewModel;
        public SettingWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            Opened += SettingWindow_Opened;
        }
        private void SettingWindow_Opened(object? sender, System.EventArgs e)
        {
            _viewModel = new SettingWindowViewModel();
            DataContext = _viewModel;
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
