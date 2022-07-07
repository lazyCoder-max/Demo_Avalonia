using Demo.Catalog.MVVM.Merchandise.ViewModels;
using Demo.Catalog.MVVM.Setting.ViewModels;
using Demo.Catalog.MVVM.Setting.Views;
using ReactiveUI;
using System;
using System.Reactive;
using System.Text;

namespace Demo.Catalog.MVVM
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Properties
        public string Title => "Demo";
        private object? _currentView;
        public object? CurrentView { get => _currentView; set => this.RaiseAndSetIfChanged(ref _currentView, value); }

        //View Models
        public MerchandiseViewModel MerchandiseVM { get; set; }
        #endregion

        #region Commands
        public ReactiveCommand<Unit, Unit> MerchandiseCommand { get; }
        public ReactiveCommand<Unit, Unit> SettingCommand { get; }
        #endregion

        #region Methods
        public MainWindowViewModel(MerchandiseViewModel merchandiseVM)
        {
            MerchandiseVM = merchandiseVM;
            MerchandiseCommand = ReactiveCommand.Create(ShowMerchandise);
            SettingCommand = ReactiveCommand.Create(ShowSetting);
        }
        void ShowMerchandise()
        {
            CurrentView = MerchandiseVM;
        }
        void ShowSetting()
        {
            var window = new SettingWindow()
            {
                WindowStartupLocation = Avalonia.Controls.WindowStartupLocation.CenterScreen
            };
            window.Show();
        }
        #endregion

        

        #region Fields

        #endregion
    }
}
