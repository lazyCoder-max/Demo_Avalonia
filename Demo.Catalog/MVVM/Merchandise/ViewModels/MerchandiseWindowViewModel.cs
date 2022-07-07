using Avalonia.Controls;
using Demo.Catalog.MVVM.Merchandise.Models;
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
        private ItemModel _model;
        #endregion

        #region Properties
        public ItemModel Model { get=> _model; set=>this.RaiseAndSetIfChanged(ref _model,value); }
        #endregion

        #region Commands
        public ReactiveCommand<Unit,Unit>? SaveCommand { get; set; }
        #endregion

        #region Methods
        public MerchandiseWindowViewModel()
        {
            _model = new ItemModel();
            SaveCommand = ReactiveCommand.Create(SaveData);
        }
        private void SaveData()
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
            else
                Model.ImagePath = result[0];
        }
        #endregion
    }
}
