using AkaShop.ViewModel.Common;
using AkaShop.ViewModel.System.Languages;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace akashop.ApiIntegration
{
    public class LanguageApiClient : BaseApiClient,ILanguageApiClient
    {
        public LanguageApiClient(IHttpClientFactory httpClientFactory,
                                 IConfiguration configuration,
                                 IHttpContextAccessor httpContextAccessor) 
                                : base(httpClientFactory,configuration,httpContextAccessor)
        {
            
        }
        public async Task<ApiResult<List<LanguageViewModel>>> GetAll()
        {
            return await GetAsync<ApiResult<List<LanguageViewModel>>>("/api/languages");
        }
    }
}
