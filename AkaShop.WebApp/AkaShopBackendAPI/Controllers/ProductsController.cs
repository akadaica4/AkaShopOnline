using AkaShop.Domain.Catalog.Products;
using AkaShop.ViewModel.Catalog.Products;
using AkaShop.ViewModel.Catalog.Products.ProductImages;
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
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService publicProductService;
        private readonly IManageProductService manageProductService;

        public ProductsController(IPublicProductService publicProductService, IManageProductService manageProductService)
        {
            this.publicProductService = publicProductService;
            this.manageProductService = manageProductService;
        }
        //http://localhost:port/products?pageIndex=1&pageSize=10&CaegoryId=1
        [HttpGet("public-paging/{languageId}")]
        public async Task<IActionResult> GetAllPaging(string languageId ,[FromQuery]GetPublicProductPagingRequest request)
        {
            var product = await publicProductService.GetAllByCategoryId(languageId, request);
            return Ok(product);
        }
        //http://localhost:port/product/1
        [HttpGet("{productId}/{languageId}")]
        public async Task<IActionResult> GetById(int productId, string languageId)
        {
            var product = await manageProductService.GetById(productId, languageId);
            if(product == null)
            {
                return BadRequest("Không tìm thấy sản phẩm");
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm]ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productId = await manageProductService.Create(request);
            if(productId == 0)
            {
                return BadRequest();
            }
            var product = await manageProductService.GetById(productId, request.LanguageId);
            return CreatedAtAction(nameof(GetById),new {id = productId },product);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var affectedResult = await manageProductService.Update(request);
            if (affectedResult == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affectedResult = await manageProductService.Delete(productId);
            if (affectedResult == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPatch("{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var isSuccessful = await manageProductService.UpdatePrice(productId, newPrice);
            if (isSuccessful)
            {
                return Ok();
            }
            return BadRequest();
        }

        //Image

        [HttpPost("{productId}/images")]
        public async Task<IActionResult> CreateImage(int productId, [FromForm] ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var imageId = await manageProductService.AddImages(productId, request);
            if (imageId == 0)
            {
                return BadRequest();
            }
            var image = await manageProductService.GetImageById(imageId);
            return CreatedAtAction(nameof(GetImageById), new { id = imageId }, image);
        }

        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await manageProductService.UpdateImages(imageId, request);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> RemoveImage(int imageId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await manageProductService.RemoveImages(imageId);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(int productId, int imageId)
        {
            var image = await manageProductService.GetImageById(imageId);
            if (image == null)
            {
                return BadRequest("Không tìm thấy sản phẩm");
            }
            return Ok(image);
        }
    }
}
