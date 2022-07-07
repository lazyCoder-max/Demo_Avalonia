using Avalonia.Controls;
using Demo.Catalog.MVVM.Merchandise.Models;
using Demo.Catalog.MVVM.Merchandise.Views;
using Demo.Catalog.Services;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Catalog.MVVM.Merchandise.ViewModels
{
    public class MerchandiseWindowViewModel:ReactiveObject
    {
        #region Fields
        private ItemModel _model;
        private CsvHelperControl serviceControl;
        #endregion

        #region Properties
        public ItemModel Model { get=> _model; set=>this.RaiseAndSetIfChanged(ref _model,value); }
        public List<ItemModel> Items { get; set; }
        #endregion

        #region Commands
        public ReactiveCommand<Unit,Unit>? SaveCommand { get; set; }
        #endregion

        #region Methods
        public MerchandiseWindowViewModel()
        {
            _model = new ItemModel();
            SaveCommand = ReactiveCommand.Create(SaveData);
            serviceControl = new CsvHelperControl();
            Items = serviceControl.GetAllData().ToList();
        }
        private void SaveData()
        {
            Items.Add(Model);
            serviceControl.SaveCsvFile(Items);
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
        public void RemoveDuplicateFile()
        {
           var records = Items.Where(x => x.Title == Model.Title && x.Description == Model.Description && x.Tags == Model.Tags && x.ImagePath == Model.ImagePath).FirstOrDefault();
           if(records!=null)
            {
                Items.Remove(records);
            }
        }
        #endregion
    }
}
