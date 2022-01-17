using AkaShop.Data.EntityFramework;
using AkaShop.ViewModel.Utilities.Slides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaShop.Domain.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly AkaShopDbContext context;

        public SlideService(IConfiguration configuration, AkaShopDbContext context)
        {
            this.context = context;
        }
        public async Task<List<SlideViewModel>> GetAll()
        {
            var slides = await context.Slides.OrderBy(x=>x.SortOrder).Select(x => new SlideViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Url = x.Url,
                Image = x.Image
                
            }).ToListAsync();
            return slides;
        }
    }
}
