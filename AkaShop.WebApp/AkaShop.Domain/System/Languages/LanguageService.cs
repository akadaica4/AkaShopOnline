using AkaShop.Data.EntityFramework;
using AkaShop.ViewModel.Common;
using AkaShop.ViewModel.System.Languages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkaShop.Domain.System.Languages
{
    public class LanguageService : ILanguageService
    {
        private readonly IConfiguration configuration;
        private readonly AkaShopDbContext context;

        public LanguageService(IConfiguration configuration,AkaShopDbContext context)
        {
            this.configuration = configuration;
            this.context = context;
        }

        public async Task<ApiResult<List<LanguageViewModel>>> GetAll()
        {
            var languages =  await context.Languages.Select(x => new LanguageViewModel() 
            {
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();
            return new ApiSuccessResult<List<LanguageViewModel>>(languages);
        }
    }
}
