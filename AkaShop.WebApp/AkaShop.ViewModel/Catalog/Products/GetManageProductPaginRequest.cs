using AkaShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AkaShop.ViewModel.Catalog.Products
{
    public class GetManageProductPaginRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public string LanguageId { get; set; }

        public int? CategoryId { get; set; }
    }
}
