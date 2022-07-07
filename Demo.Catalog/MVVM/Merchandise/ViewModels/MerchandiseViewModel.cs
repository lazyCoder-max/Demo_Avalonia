using Demo.Catalog.MVVM.Merchandise.Views;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Catalog.MVVM.Merchandise.ViewModels
{
    public class MerchandiseViewModel:ReactiveObject
    {
        #region Fields

        #endregion

        #region Properties

        #endregion

        #region Commands
        public ReactiveCommand<Unit, Unit>? OpenCommand { get; set; }
        public ReactiveCommand<Unit, Unit>? CreateCommand { get; set; }
        #endregion

        #region Methods
        public MerchandiseViewModel()
        {
            OpenCommand = ReactiveCommand.Create(ShowOpenWindow);
            CreateCommand = ReactiveCommand.Create(ShowCreateWindow);
        }
        void ShowCreateWindow()
        {
            var window = new MerchandiseWindow()
            {
                 WindowStartupLocation = Avalonia.Controls.WindowStartupLocation.CenterScreen
            };
            window.Show();
        }
        void ShowOpenWindow()
        {

        }
        #endregion
    }
}
