using AutoMapper;
using IdentityTesting.Facade.DTOs;
using IdentityTesting.Service;
using IdentityTesting.Service.Implementations;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IdentityTesting.Facade.Implementations
{
    public class AccountServiceFacade : IAccountServiceFacade
    {
        public IUserAuthenticationService userAuthService { get; set; }
        public AccountServiceFacade()
        {
            userAuthService = new UserAuthenticationService();
        }
        public async Task<IdentityResult> CreateAsync(string username, string password)
        {
            return await userAuthService.CreateAsync(username, password);
        }
        public async Task<ClaimsIdentity> CreateIdentityAsync(string username, string authenticationType)
        {
            return await userAuthService.CreateIdentityAsync(username, authenticationType);
        }
        public async Task<bool> IsUserExistsAsync(string username, string password)
        {
            return await userAuthService.IsUserExistsAsync(username, password);
        }
        public async Task<IdentityResult> RemoveLoginAsync(string userId, string loginProvider, string providerKey)
        {
            return await userAuthService.RemoveLoginAsync(userId, new UserLoginInfo(loginProvider, providerKey));
        }
        public async Task<IdentityResult> ChangePasswordAsync(string userId, string oldPassword, string newPassword)
        {
            return await userAuthService.ChangePasswordAsync(userId, oldPassword, newPassword);
        }
        public async Task<IdentityResult> AddPasswordAsync(string userId, string newPassword)
        {
            return await userAuthService.AddPasswordAsync(userId, newPassword);
        }
        public async Task<ApplicationUserDTO> FindAsync(UserLoginInfo userLoginInfo)
        {
            var user = await userAuthService.FindAsync(userLoginInfo);
            return new ApplicationUserDTO { UserName = user.UserName };
        }
        public async Task<IdentityResult> AddLoginAsync(string userId, UserLoginInfo userLoginInfo)
        {
            return await userAuthService.AddLoginAsync(userId, userLoginInfo);
        }
        public async Task<IdentityResult> CreateAsync(string username)
        {
            return await userAuthService.CreateAsync(username);
        }
        public IList<UserLoginInfo> GetLogins(string userId)
        {
            return userAuthService.GetLogins(userId);
        }
        public ApplicationUserDTO FindById(string userId)
        {
            var user = userAuthService.FindById(userId);
            return new ApplicationUserDTO
            {
                AccessFailedCount = user.AccessFailedCount,
                Email = user.Email,
                EmailConfirmed = user.EmailConfirmed,
                Id = user.Id,
                LockoutEnabled = user.LockoutEnabled,
                LockoutEndDateUtc = user.LockoutEndDateUtc,
                UserName = user.UserName,
                PasswordHash = user.PasswordHash,
                PhoneNumber = user.PhoneNumber,
                PhoneNumberConfirmed = user.PhoneNumberConfirmed,
                SecurityStamp = user.SecurityStamp,
                TwoFactorEnabled = user.TwoFactorEnabled
            };
        }
    }
}
