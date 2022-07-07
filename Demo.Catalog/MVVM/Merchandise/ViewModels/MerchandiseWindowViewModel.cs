using Avalonia.Controls;
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
    internal class MerchandiseWindowViewModel:ReactiveObject
    {
        #region Fields

        #endregion

        #region Properties

        #endregion

        #region Commands
        #endregion

        #region Methods
        public MerchandiseWindowViewModel()
        {
        }
        public async Task OpenFileDialog(object sender)
        {
            var window = sender as MerchandiseWindow;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.AllowMultiple = false;
            dialog.Filters.Add(new FileDialogFilter() { Name = "Image", Extensions = { "jpg" } });

            string[] result = await dialog.ShowAsync(window);

            if (result == null)
            {
                await OpenFileDialog(sender);
            }
        }
        #endregion
    }
}
