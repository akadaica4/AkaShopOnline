using AkaShop.Domain.Catalog.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkaShopBackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(string languageId)
        {
            var category = await categoryService.GetAll(languageId);
            return Ok(category);
        }


        [HttpGet("{id}/{languageId}")]
        public async Task<IActionResult> GetById(string languageId,int id)
        {
            var category = await categoryService.GetById(languageId,id);
            return Ok(category);
        }
    }
}
