using Demo.Catalog.MVVM.Merchandise.Models;
using Demo.Catalog.Services;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Catalog.MVVM.Setting.ViewModels
{
    public class SettingWindowViewModel:ReactiveObject
    {
        #region Fields
        private ItemSettingModel _model;
        private CsvHelperControl serviceControl;
        #endregion

        #region Properties
        public ItemSettingModel Model { get => _model; set => this.RaiseAndSetIfChanged(ref _model, value); }
        #endregion

        #region Commands
        public ReactiveCommand<Unit, Unit>? SaveCommand { get; set; }
        #endregion

        #region Methods
        public SettingWindowViewModel()
        {
            _model = new ItemSettingModel();
            serviceControl = new CsvHelperControl();
            SaveCommand = ReactiveCommand.Create(SaveData);
        }
        private void SaveData()
        {
            serviceControl.SaveSetting(Model);
        }
        #endregion
    }
}
