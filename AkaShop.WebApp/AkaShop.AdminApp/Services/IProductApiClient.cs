using AkaShop.ViewModel.Catalog.Products;
using AkaShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkaShop.AdminApp.Services
{
    public interface IProductApiClient
    {
        Task<PageResult<ProductViewModel>> GetPaging(GetManageProductPaginRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);


        Task<ProductViewModel> GetById(int id, string languageId);
    }
}
