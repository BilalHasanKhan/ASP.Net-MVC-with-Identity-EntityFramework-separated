using IdentityTesting.Entities.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IdentityTesting.Service
{
    public interface IUserAuthenticationService
    {
        Task<IdentityResult> CreateAsync(string username, string password);
        Task<ClaimsIdentity> CreateIdentityAsync(string username, string authenticationType);
        Task<bool> IsUserExistsAsync(string username, string password);
        Task<IdentityResult> RemoveLoginAsync(string userId, UserLoginInfo userLoginInfo);
        Task<IdentityResult> ChangePasswordAsync(string userId, string oldPassword, string newPassword);
        Task<IdentityResult> AddPasswordAsync(string userId, string newPassword);
        Task<ApplicationUser> FindAsync(UserLoginInfo userLoginInfo);
        Task<IdentityResult> AddLoginAsync(string userId, UserLoginInfo userLoginInfo);
        Task<IdentityResult> CreateAsync(string username);
        IList<UserLoginInfo> GetLogins(string userId);
        ApplicationUser FindById(string userId);
    }
}
