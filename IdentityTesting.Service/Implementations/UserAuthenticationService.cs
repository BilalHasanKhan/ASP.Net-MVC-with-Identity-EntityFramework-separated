using IdentityTesting.Entities.Models;
using IdentityTesting.Manager;
using IdentityTesting.Manager.Implementations;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IdentityTesting.Service.Implementations
{
    public class UserAuthenticationService : IUserAuthenticationService
    {
        public IUserIdentityManager<ApplicationUser> identityManager { get; set; }
        public IUserPresistanceManager presistanceManager { get; set; }
        public UserAuthenticationService()
        {
            presistanceManager = new UserPresistanceManager();
            identityManager = new UserIdentityManager();
        }
        public async Task<IdentityResult> CreateAsync(string username, string password)
        {
            return await identityManager.CreateAsync(username, password);
        }
        public async Task<ClaimsIdentity> CreateIdentityAsync(string username, string authenticationType)
        {
            var user = presistanceManager.GetUserByUsername(username);
            return await identityManager.CreateIdentityAsync(user, authenticationType);
        }
        public async Task<bool> IsUserExistsAsync(string username, string password)
        {
            return await identityManager.FindAsync(username, password) != null;
        }
        public async Task<IdentityResult> RemoveLoginAsync(string userId, UserLoginInfo userLoginInfo)
        {
            return await identityManager.RemoveLoginAsync(userId, userLoginInfo);
        }
        public async Task<IdentityResult> ChangePasswordAsync(string userId, string oldPassword, string newPassword)
        {
            return await identityManager.ChangePasswordAsync(userId, oldPassword, newPassword);
        }
        public async Task<IdentityResult> AddPasswordAsync(string userId, string newPassword)
        {
            return await identityManager.AddPasswordAsync(userId, newPassword);
        }
        public async Task<ApplicationUser> FindAsync(UserLoginInfo userLoginInfo)
        {
            return await identityManager.FindAsync(userLoginInfo);
        }
        public async Task<IdentityResult> AddLoginAsync(string userId, UserLoginInfo userLoginInfo)
        {
            return await identityManager.AddLoginAsync(userId, userLoginInfo);
        }
        public async Task<IdentityResult> CreateAsync(string username)
        {
            return await identityManager.CreateAsync(username);
        }
        public IList<UserLoginInfo> GetLogins(string userId)
        {
            return identityManager.GetLogins(userId);
        }
        public ApplicationUser FindById(string userId)
        {
            return identityManager.FindById(userId);
        }
    }
}
