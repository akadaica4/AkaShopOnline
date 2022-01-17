using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AkaShop.ViewModel.Catalog.Products
{
    public class ProductCreateRequest
    {
        [Display(Name = "Tên sản phẩm")]
        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        public string Name { get; set; }
        [Display(Name = "Giá sản phẩm")]
        [Required(ErrorMessage ="Bạn phải nhập giá sản phẩm")]
        public decimal Price { get; set; }
        [Display(Name = "Giá gốc")]
        [Required(ErrorMessage = "Bạn phải nhập giá gốc")]
        public decimal OriginalPrice { get; set; }
        [Display(Name = "Số lượng tồn")]
        public int Stock { get; set; }
        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Bạn phải nhập mô tả sản phẩm")]
        public string Description { get; set; }
        [Display(Name = "Chi tiết sản phẩm")]
        [Required(ErrorMessage = "Bạn phải nhập chi tiết sản phẩm")]
        public string Details { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string SeoAlias { get; set; }
        public string LanguageId { get; set; }

        public bool? IsFeatured { get; set; }
        public IFormFile ThumbnailImage { get; set; }
    }
}
