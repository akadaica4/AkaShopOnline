using AkaShop.ViewModel.Catalog.Products;
using AkaShop.ViewModel.Catalog.Products.ProductImages;
using AkaShop.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AkaShop.Domain.Catalog.Products
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<ProductViewModel> GetById(int productId, string languageId);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewcount(int productId);
        Task<PageResult<ProductViewModel>> GetAllPaging(GetManageProductPaginRequest request);
        Task<int> AddImages(int productId, ProductImageCreateRequest request);
        Task<int> RemoveImages(int imageId);
        Task<int> UpdateImages(int imageId, ProductImageUpdateRequest request);
        Task<List<ProductImageViewModel>> GetListImage(int productId);
        Task<ProductImageViewModel> GetImageById(int imageId);
        Task<PageResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<List<ProductViewModel>> GetFeaturedProducts(string languageId, int take);

        Task<List<ProductViewModel>> GetLatestdProducts(string languageId, int take);

    }
}
