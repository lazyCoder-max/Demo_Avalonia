﻿using Demo.Catalog.MVVM.Merchandise.Models;
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
    public class MerchandiseViewModel:ReactiveObject
    {
        #region Fields
        public List<ItemModel> items;
        private ItemModel selectedItem;
        private CsvHelperControl serviceControl;
        #endregion

        #region Properties
        public List<ItemModel> Items { get=>items; set=>this.RaiseAndSetIfChanged(ref items, value); }
        public ItemModel SelectedItem { get=>selectedItem; set=>this.RaiseAndSetIfChanged(ref selectedItem,value); }
        #endregion

        #region Commands
        public ReactiveCommand<Unit, Unit>? OpenCommand { get; set; }
        public ReactiveCommand<Unit, Unit>? CreateCommand { get; set; }
        #endregion

        #region Methods
        public MerchandiseViewModel()
        {
            items = new List<ItemModel>();
            OpenCommand = ReactiveCommand.Create(ShowOpenWindow);
            CreateCommand = ReactiveCommand.Create(ShowCreateWindow);
            serviceControl = new CsvHelperControl();
            var result = serviceControl.GetAllData();
            if(result.Count()>=1)
            {
                Items = result.ToList();
            }
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
