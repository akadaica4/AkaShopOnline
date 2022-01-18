using AkaShop.ViewModel.Catalog.Products;
using AkaShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkaShop.BEApiIntegration
{
    public interface IProductApiClient
    {
        Task<PageResult<ProductViewModel>> GetPaging(GetManageProductPaginRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);


        Task<ProductViewModel> GetById(int id, string languageId);

        Task<List<ProductViewModel>> GetFeaturedProducts( string languageId, int take);
        Task<List<ProductViewModel>> GetLatestdProducts(string languageId, int take);


        Task<bool> UpdateProduct(ProductUpdateRequest request);
    }
}
