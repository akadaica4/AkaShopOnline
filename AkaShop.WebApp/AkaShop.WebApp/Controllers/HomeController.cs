using AkaShop.BEApiIntegration;
using AkaShop.Utilities.Constants;
using AkaShop.WebApp.Models;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace AkaShop.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISlideApiClient slideApiClient;
        private readonly IProductApiClient productApiClient;

        public HomeController(ILogger<HomeController> logger, ISlideApiClient slideApiClient, IProductApiClient productApiClient)
        {
            _logger = logger;
            this.slideApiClient = slideApiClient;
            this.productApiClient = productApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var culture = CultureInfo.CurrentCulture.Name;
            var viewmodel = new HomeViewModel
            {
                Slides = await slideApiClient.GetAll(),
                FeaturedProducts = await productApiClient.GetFeaturedProducts(culture, SystemConstants.ProductSetting.NumberOfFeaturedProducts),
                LatestProducts = await productApiClient.GetLatestdProducts(culture, SystemConstants.ProductSetting.NumberOfLatestProducts)
            };
            return View(viewmodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SetCultureCookie(string cltr, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(cltr)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );

            return LocalRedirect(returnUrl);
        }
    }
}
