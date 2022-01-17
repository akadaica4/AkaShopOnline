using AkaShop.ViewModel.Catalog.Products;
using AkaShop.ViewModel.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkaShop.WebApp.Models
{
    public class HomeViewModel
    {
        public List<SlideViewModel> Slides { get; set; }
        public List<ProductViewModel> FeaturedProducts { get; set; }

        public List<ProductViewModel> LatestProducts { get; set; }
    }
}
