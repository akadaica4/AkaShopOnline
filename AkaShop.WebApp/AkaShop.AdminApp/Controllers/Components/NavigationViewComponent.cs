using AkaShop.AdminApp.Services;
using AkaShop.AdminApp.Models;
using AkaShop.Utilities.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AkaShop.AdminApp.Controllers.Components
{
    public class NavigationViewComponent : ViewComponent
    {
        private readonly ILanguageApiClient languageApiClient;

        public NavigationViewComponent(ILanguageApiClient languageApiClient)
        {
            this.languageApiClient = languageApiClient;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var languages = await languageApiClient.GetAll();
            var navigationVm = new NavigationViewModel()
            {
                CurrenLangugeId = HttpContext.Session.GetString(SystemConstants.AppSettings.DefaultLanguageId),
                Languages = languages.ResultObj
            };
            return View("Default", navigationVm);
        }
    }
}
