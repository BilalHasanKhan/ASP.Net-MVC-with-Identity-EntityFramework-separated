using IdentityTesting.Facade.DTOs;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IdentityTesting.Facade
{
    public interface IAccountServiceFacade
    {
        Task<IdentityResult> CreateAsync(string username, string password);
        Task<ClaimsIdentity> CreateIdentityAsync(string username, string authenticationType);
        Task<bool> IsUserExistsAsync(string username, string password);
        Task<IdentityResult> RemoveLoginAsync(string userId, string loginProvider, string providerKey);
        Task<IdentityResult> ChangePasswordAsync(string userId, string oldPassword, string newPassword);
        Task<IdentityResult> AddPasswordAsync(string userId, string newPassword);
        Task<ApplicationUserDTO> FindAsync(UserLoginInfo userLoginInfo);
        Task<IdentityResult> AddLoginAsync(string userId, UserLoginInfo userLoginInfo);
        Task<IdentityResult> CreateAsync(string username);
        IList<UserLoginInfo> GetLogins(string userId);
        ApplicationUserDTO FindById(string userId);
    }
}
