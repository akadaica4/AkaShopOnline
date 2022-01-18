using AkaShop.ViewModel.Catalog.Categories;
using AkaShop.ViewModel.Catalog.Products;
using AkaShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkaShop.WebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryViewModel Category { get; set; }
        public PageResult<ProductViewModel> Products { get; set; }
    }
}
