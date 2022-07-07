using CsvHelper.Configuration.Attributes;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Catalog.MVVM.Merchandise.Models
{
    public class ItemModel:ReactiveObject
    {
        private string title;
        private string description;
        private string tags;
        private string imagePath;
        [Name("title")]
        public string Title { get => title; set => this.RaiseAndSetIfChanged(ref title, value); }
        [Name("description")]
        public string Description { get => description; set => this.RaiseAndSetIfChanged(ref description, value); }
        [Name("tags")]
        public string Tags { get => tags; set => this.RaiseAndSetIfChanged(ref tags, value); }
        
        [Name("image_path")]
        public string ImagePath { get => imagePath; set => this.RaiseAndSetIfChanged(ref imagePath, value); }
    }
}
