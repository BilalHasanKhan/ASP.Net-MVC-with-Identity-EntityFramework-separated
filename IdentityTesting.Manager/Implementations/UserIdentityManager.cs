using IdentityTesting.Entities;
using IdentityTesting.Entities.Context;
using IdentityTesting.Entities.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IdentityTesting.Manager.Implementations
{
    public class UserIdentityManager : IUserIdentityManager<ApplicationUser>
    {
        public UserIdentityManager()
        {
            identityUserStore = new IdentityUserStore<ApplicationUser>(new IdentityTestingContext());
            identityUserManager = new UserManager<ApplicationUser>(identityUserStore);
        }
        public IUserStore<ApplicationUser> identityUserStore { get; set; }
        public UserManager<ApplicationUser> identityUserManager { get; set; }
        public async Task<IdentityResult> CreateAsync(string username, string password)
        {
            var user = new ApplicationUser { UserName = username };
            return await identityUserManager.CreateAsync(user, password);
        }
        public async Task<ClaimsIdentity> CreateIdentityAsync(ApplicationUser user, string authenticationType)
        {
            return await identityUserManager.CreateIdentityAsync(user, authenticationType);
        }
        public async Task<ApplicationUser> FindAsync(string username, string password)
        {
            return await identityUserManager.FindAsync(username, password);
        }
        public async Task<IdentityResult> RemoveLoginAsync(string userId, UserLoginInfo userLoginInfo)
        {
            return await identityUserManager.RemoveLoginAsync(userId, userLoginInfo);
        }
        public async Task<IdentityResult> ChangePasswordAsync(string userId, string oldPassword, string newPassword)
        {
            return await identityUserManager.ChangePasswordAsync(userId, oldPassword, newPassword);
        }
        public async Task<IdentityResult> AddPasswordAsync(string userId, string newPassword)
        {
            return await identityUserManager.AddPasswordAsync(userId, newPassword);
        }
        public async Task<ApplicationUser> FindAsync(UserLoginInfo userLoginInfo)
        {
            return await identityUserManager.FindAsync(userLoginInfo);
        }
        public async Task<IdentityResult> AddLoginAsync(string userId, UserLoginInfo userLoginInfo)
        {
            return await identityUserManager.AddLoginAsync(userId, userLoginInfo);
        }
        public async Task<IdentityResult> CreateAsync(string username)
        {
            var user = new ApplicationUser { UserName = username };
            return await identityUserManager.CreateAsync(user);
        }
        public IList<UserLoginInfo> GetLogins(string userId)
        {
            return identityUserManager.GetLogins(userId);
        }
        public ApplicationUser FindById(string userId)
        {
            return identityUserManager.FindById(userId);
        }
    }
}
