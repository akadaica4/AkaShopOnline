using System;
using System.Collections.Generic;
using System.Text;

namespace AkaShop.ViewModel.Catalog.Categories
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }
}
