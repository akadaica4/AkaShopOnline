using AkaShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AkaShop.ViewModel.Catalog.Products
{
    public class GetManageProductPaginRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
