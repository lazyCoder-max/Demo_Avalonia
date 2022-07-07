using CsvHelper.Configuration;
using Demo.Catalog.MVVM.Merchandise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Catalog.Services
{
    internal class ItemSettingModelClassMap : ClassMap<ItemSettingModel>
    {
        public ItemSettingModelClassMap()
        {
            Map(m => m.TitleLength).Name("title_length");
            Map(m => m.DescriptionLength).Name("description_length");
            Map(m => m.TagsLength).Name("tags_length");
            Map(m => m.ImagePathLength).Name("image_path_length");
        }
    }
}
