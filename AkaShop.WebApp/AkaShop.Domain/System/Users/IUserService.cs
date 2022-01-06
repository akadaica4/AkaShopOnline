using AkaShop.ViewModel.Common;
using AkaShop.ViewModel.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AkaShop.Domain.System.Users
{
    public interface IUserService
    {
        Task<string> Authencate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);

        Task<PageResult<UserViewModel>> GetUserPaging(GetUserPagingRequest request);
    }
}
