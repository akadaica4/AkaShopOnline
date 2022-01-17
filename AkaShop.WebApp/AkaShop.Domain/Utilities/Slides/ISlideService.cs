using AkaShop.ViewModel.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AkaShop.Domain.Utilities.Slides
{
    public interface ISlideService
    {
        Task<List<SlideViewModel>> GetAll();
    }
}
