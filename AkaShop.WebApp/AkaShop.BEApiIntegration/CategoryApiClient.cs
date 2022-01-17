using AkaShop.BEApiIntegration;
using AkaShop.ViewModel.Catalog.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AkaShop.BEApiIntegration
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        private readonly IConfiguration configuration;

        public CategoryApiClient(IHttpClientFactory httpClientFactory,
                                 IConfiguration configuration,
                                 IHttpContextAccessor httpContextAccessor)
                                 : base(httpClientFactory, configuration, httpContextAccessor)

        {
            this.configuration = configuration;
        }
        public async Task<List<CategoryViewModel>> GetAll(string languageId)
        {
            return await GetListAsync<CategoryViewModel>("/api/categories?languageId=" + languageId);
        }
    }
}
