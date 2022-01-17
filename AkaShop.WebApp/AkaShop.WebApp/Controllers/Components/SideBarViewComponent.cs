using AkaShop.BEApiIntegration;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace AkaShop.WebApp.Controllers.Components
{
    
    public class SideBarViewComponent : ViewComponent
    {
        private readonly ICategoryApiClient categoryApiClient;

        public SideBarViewComponent(ICategoryApiClient categoryApiClient)
        {
            this.categoryApiClient = categoryApiClient;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await categoryApiClient.GetAll(CultureInfo.CurrentCulture.Name);
            return View(items);
        }
    }
}
