using AkaShop.BEApiIntegration;
using AkaShop.ViewModel.Catalog.Products;
using AkaShop.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkaShop.WebApp.Controllers.Components
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient productApiClient;
        private readonly ICategoryApiClient categoryApiClient;

        public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
        {
            this.productApiClient = productApiClient;
            this.categoryApiClient = categoryApiClient;
        }
        public async Task<IActionResult> Detail(int id)
        {
            
            return View();
        }

        public async Task<IActionResult> Category(int id, string culture, int page = 1)
        {
            var products = await productApiClient.GetPaging(new GetManageProductPaginRequest()
            {
                CategoryId = id,
                PageIndex = page,
                LanguageId = culture,
                PageSize = 10
            });
            return View(new ProductCategoryViewModel() 
            { 
                Category = await categoryApiClient.GetById(culture,id),
                Products = products
            });
        }
    }
}

