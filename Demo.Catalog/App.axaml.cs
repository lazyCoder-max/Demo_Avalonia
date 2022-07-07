using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Demo.Catalog.MVVM;
using Demo.Catalog.MVVM.Merchandise.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Catalog
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
        public App()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();

            DependencyProvider.Instance.SetServiceProvider(serviceProvider);
        }
        private void ConfigureServices(ServiceCollection services)
        {

            // ViewModels
            services.AddTransient<MainWindowViewModel>();
            services.AddSingleton<MerchandiseViewModel>();

            // Views
            services.AddSingleton(sp =>
            {
                var mainViewModel = sp.GetRequiredService<MainWindowViewModel>();

                var mainWindow = new MainWindow();
                mainWindow.DataContext = mainViewModel;

                return mainWindow;
            });
        }
        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(new MerchandiseViewModel()),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
