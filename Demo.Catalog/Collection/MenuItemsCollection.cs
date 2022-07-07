using Avalonia.Controls;
using Demo.Catalog.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Catalog.Collection
{
    internal class MenuItemsCollection:List<Menu>
    {
        public MenuItemsCollection()
        {
            AddRange(new Menu[] {

                new Menu { Name = MenuConstant.Merchandise },
                new Menu {Name = MenuConstant.Settings },
            });
        }
    }
}
