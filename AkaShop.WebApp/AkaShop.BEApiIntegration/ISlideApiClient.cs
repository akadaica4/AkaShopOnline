using AkaShop.ViewModel.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AkaShop.BEApiIntegration
{
    public interface ISlideApiClient
    {
        Task<List<SlideViewModel>> GetAll();
    }
}
