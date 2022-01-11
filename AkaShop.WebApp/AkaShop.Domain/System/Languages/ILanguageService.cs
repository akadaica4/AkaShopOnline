using AkaShop.ViewModel.Common;
using AkaShop.ViewModel.System.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AkaShop.Domain.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageViewModel>>> GetAll();
        
    }
}
