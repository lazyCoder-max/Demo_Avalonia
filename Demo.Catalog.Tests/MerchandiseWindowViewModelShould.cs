using Demo.Catalog.MVVM.Merchandise.Models;
using Demo.Catalog.MVVM.Merchandise.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Catalog.Tests
{
    [TestFixture]
    
    public class MerchandiseWindowViewModelShould
    {
        [Test]
        public void Return_False_RemoveDuplicateFile_EmptyData()
        {
            ItemModel model = new ItemModel();
            var viewModel = new MerchandiseWindowViewModel();
            viewModel.Model = model;
            var result = viewModel.RemoveDuplicateFile();
            Assert.That(result, Is.EqualTo(false));
        }
    }
}
