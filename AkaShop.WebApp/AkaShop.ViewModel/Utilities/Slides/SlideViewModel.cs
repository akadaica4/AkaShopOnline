using AkaShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AkaShop.ViewModel.Utilities.Slides
{
    public class SlideViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int SortOrder { get; set; }
        public string Image { get; set; }
    }
}
