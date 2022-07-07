using CsvHelper.Configuration;
using Demo.Catalog.MVVM.Merchandise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Catalog.Services
{
    internal class ItemModelClassMap:ClassMap<ItemModel>
    {
        public ItemModelClassMap()
        {
            Map(m => m.Title).Name("title");
            Map(m => m.Description).Name("description");
            Map(m => m.Tags).Name("tags");
            Map(m => m.ImagePath).Name("image_path");
        }
    }
}
