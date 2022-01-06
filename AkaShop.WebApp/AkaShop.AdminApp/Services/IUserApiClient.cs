using AkaShop.ViewModel.Common;
using AkaShop.ViewModel.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkaShop.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);

        Task<PageResult<UserViewModel>> GetUsersPaging(GetUserPagingRequest request);

        Task<bool> RegisterUser(RegisterRequest request);
    }
}
