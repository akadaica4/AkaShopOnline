using AkaShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AkaShop.ViewModel.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
