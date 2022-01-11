using AkaShop.Domain.System.Languages;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AkaShopBackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly ILanguageService languageService;

        public LanguagesController(ILanguageService languageService)
        {
            this.languageService = languageService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var product = await languageService.GetAll();
            return Ok(product);
        }
    }
}
