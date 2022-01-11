using AkaShop.Data.Entities;
using AkaShop.ViewModel.System.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaShop.Domain.System.Roles
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> roleManager;

        public RoleService(RoleManager<AppRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public async Task<List<RoleViewModel>> GetAll()
        {
            var roles = await roleManager.Roles.Select(x => new RoleViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description
            }).ToListAsync();
            return roles;
        }
    }
}
