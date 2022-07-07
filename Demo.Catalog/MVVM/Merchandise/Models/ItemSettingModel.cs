using CsvHelper.Configuration.Attributes;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Catalog.MVVM.Merchandise.Models
{
    public class ItemSettingModel:ReactiveObject
    {
        private int titleLength;
        private int descriptionLength;
        private int tagsLength;
        private int imagePathLength;
        [Name("title_length")]
        public int TitleLength { get => titleLength; set => this.RaiseAndSetIfChanged(ref titleLength, value); }
        [Name("description_length")]
        public int DescriptionLength { get => descriptionLength; set => this.RaiseAndSetIfChanged(ref descriptionLength, value); }
        [Name("tags_length")]
        public int TagsLength { get => tagsLength; set => this.RaiseAndSetIfChanged(ref tagsLength, value); }
        
        [Name("image_path_length")]
        public int ImagePathLength { get => imagePathLength; set => this.RaiseAndSetIfChanged(ref imagePathLength, value); }
    }
}
