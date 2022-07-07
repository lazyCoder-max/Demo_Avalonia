using Avalonia.Controls;

namespace Demo.Catalog.MVVM
{
    public partial class MainWindow : Window
    {
        private MainWindowViewModel? _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            Opened += MainWindow_Opened;
        }

        private void MainWindow_Opened(object? sender, System.EventArgs e)
        {
           _viewModel = DataContext as MainWindowViewModel;
        }
    }
}
