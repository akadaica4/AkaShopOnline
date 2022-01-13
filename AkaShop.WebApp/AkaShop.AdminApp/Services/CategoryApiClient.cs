﻿using AkaShop.ViewModel.Catalog.Categories;
using AkaShop.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AkaShop.AdminApp.Services
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        public CategoryApiClient(IHttpClientFactory httpClientFactory,
                                 IConfiguration configuration,
                                 IHttpContextAccessor httpContextAccessor)
                                 : base(httpClientFactory, configuration, httpContextAccessor)

        {

        }
        public async Task<List<CategoryViewModel>> GetAll(string languageId)
        {
            return await GetListAsync<CategoryViewModel>("/api/categories?languageId=" + languageId);
        }
    }
}
