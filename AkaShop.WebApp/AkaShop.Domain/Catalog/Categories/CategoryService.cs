using AkaShop.Data.EntityFramework;
using AkaShop.Domain.Common;
using AkaShop.ViewModel.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AkaShop.Domain.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly AkaShopDbContext context;
        public CategoryService(AkaShopDbContext context)
        {
            this.context = context;
        }
        public async Task<List<CategoryViewModel>> GetAll(string languageId)
        {
            var query = from c in context.Categories
                        join ct in context.CategoryTranslations on c.Id equals ct.CategoryId
                        where ct.LanguageId == languageId
                        select new { c, ct };
            return await query.Select(x => new CategoryViewModel()
            {
                Id = x.c.Id,
                Name = x.ct.Name,
                ParentId = x.c.ParentId

            }).ToListAsync();
        }

        public async Task<CategoryViewModel> GetById(string languageId, int id)
        {
            var query = from c in context.Categories
                        join ct in context.CategoryTranslations on c.Id equals ct.CategoryId
                        where ct.LanguageId == languageId && c.Id == id
                        select new { c, ct };
            return await query.Select(x => new CategoryViewModel()
            {
                Id = x.c.Id,
                Name = x.ct.Name,
                ParentId = x.c.ParentId

            }).FirstOrDefaultAsync();
        }
    }
}
