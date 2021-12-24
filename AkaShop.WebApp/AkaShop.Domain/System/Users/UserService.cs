using AkaShop.Data.Entities;
using AkaShop.Utilities.Exceptions;
using AkaShop.ViewModel.System.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AkaShop.Domain.System.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signManager;
        private readonly RoleManager<AppRole> roleManager;
        private readonly IConfiguration configuration;

        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signManager,RoleManager<AppRole> roleManager,IConfiguration configuration)
        {
            this.userManager = userManager;
            this.signManager = signManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
        }
        public async Task<string> Authencate(LoginRequest request)
        {
            var user = await userManager.FindByNameAsync(request.UserName);
            if(user == null)
            {
                return null;
            }
            var result = await signManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return null;
            }
            var roles = await userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.GivenName,user.FirsName),
                new Claim(ClaimTypes.Role,string.Join(";",roles))
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(configuration["Tokens:Issuer"],
                configuration["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            var user = new AppUser()
            {
                Dob = request.Dob,
                Email = request.Email,
                FirsName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber
            };
            var result = await userManager.CreateAsync(user,request.Password);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }
    }
}
