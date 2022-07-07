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
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public string ImagePath { get; set; }
    }
}
