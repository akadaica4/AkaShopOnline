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
        Task<ApiResult<string>> Authencate(LoginRequest request);
        Task<ApiResult<bool>> Register(RegisterRequest request);
        Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);
        Task<ApiResult<PageResult<UserViewModel>>> GetUserPaging(GetUserPagingRequest request);
        Task<ApiResult<UserViewModel>> GetById(Guid id);

        Task<ApiResult<bool>> Delete(Guid id);

        Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request);
    }
}
